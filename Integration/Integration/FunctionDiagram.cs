using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Integration
{
    public struct Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public bool InFunction { get; set; }
    }

    public sealed class FunctionDiagram : GameWindow
    {
        #region Поля

        private static Random rnd = new Random();

        private double left, right, bottom, top;
        private double pointMin, pointMax;

        private readonly Mydel func;
        private readonly bool isVisualize;

        private Point[] coordPoints;
        private double[] GrapValuesArray;
        private double mouseCoordX, mouseCoordY;

        #endregion

        /// <summary>
        /// Создает новый экземпляр класса
        /// </summary>
        /// <param name="function">Функция, график которой будет изображен</param>
        /// <param name="A">Нижний предел интегрирования</param>
        /// <param name="B">Верхний предел интегрирования</param>
        /// <param name="coordPoints">Массив структур Point, который содержит точки для метода Монте-Карло</param>
        /// <param name="isVisualize">true, если рисовать точки на графике</param>
        public FunctionDiagram(Mydel function, double A, double B, Point[] coordPoints, bool isVisualize)
            : base(400, 400, GraphicsMode.Default, "График функции")
        {
            mouseCoordX = mouseCoordY = 0f;
            pointMin = pointMax = 0f;

            this.func = function;
            this.isVisualize = isVisualize;
            this.coordPoints = coordPoints;

            left = A;
            right = B;

            FunctionCalculation();
        }

        // Вызывается при перемещении мыши в окне opengl
        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            base.OnMouseMove(e);

            double devX = Width / (right - left);
            double devY = Height / (top - bottom);

            if (left < 0.0 && e.X < -left * devX) mouseCoordX = left - e.X / -devX;
            else mouseCoordX = left + e.X / devX;

            if (e.Y < top * devY) mouseCoordY = top - e.Y / devY;
            else mouseCoordY = e.Y / -devY;

            Title = String.Format("x: {0:0.0000}; f(x): {1:0.0000}", mouseCoordX, func(mouseCoordX));
        }

        // Вызывается при первоначальной загрузке
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color4.White); // Зададим цвет очистки окна
        }

        // Вызывается при изменение размеров окна
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height); // Зададим область перерисовки размером со всё окно
        }

        // Вызывается при отрисовке очередного кадра
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit); // Очищаем буфер цвета

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(left, right, bottom, top, 0.0, 1.0);

            /* Отрисовка точек из массива */
            DrawPoints();

            /* Оси координат */
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(Color.Black);
            GL.Vertex2(left, 0.0f);
            GL.Vertex2(right, 0.0f);

            GL.End();

            /* График функции */
            GL.LineWidth(2);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Color3(Color.MidnightBlue);

            int i = 0;
            for (double x = left; x < right; x += 0.001f)
                GL.Vertex2(x, GrapValuesArray[i++]);

            GL.End();

            /* Перпендикуляр от курсора до оси координат */
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);

            if (mouseCoordY < 0.0f)
                GL.Vertex2(mouseCoordX, bottom);
            else
                GL.Vertex2(mouseCoordX, top);
            
            GL.Vertex2(mouseCoordX, 0.0f);
            GL.End();

            SwapBuffers(); // Переключаем задний и передний буферы
        }

        private void DrawPoints()
        {
            if (isVisualize)
            {
                GL.Begin(PrimitiveType.Points);

                for (int i = 0; i < coordPoints.Length; i++)
                {
                    if (coordPoints[i].InFunction)
                        GL.Color3(Color.Blue);
                    else
                        GL.Color3(Color.Red);

                    GL.Vertex2(coordPoints[i].X, coordPoints[i].Y);
                }
                GL.End();
            }
        }

        private void FunctionCalculation()
        {
            //double minY = 0, maxY = 0;
            List<double> resFunction = new List<double>();

            for (double x = left; x < right; x += 0.001d)
            {
                double xi = func.Invoke(x);

                if (xi > pointMax) pointMax = xi;
                if (xi < pointMin) pointMin = xi;

                resFunction.Add(xi);
            }

            double dh = pointMax - pointMin;

            top = pointMax + dh * 0.1f;
            bottom = (pointMin < 0.0) ? pointMin + dh * -0.1f : -0.1f * dh;
            
            GrapValuesArray = resFunction.ToArray();
        }
    }
}
