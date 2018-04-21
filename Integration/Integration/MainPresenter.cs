using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    internal class MainPresenter
    {
        private readonly IMainForm mainForm;
        private readonly MyModel myModel;
        private FunctionDiagram diagram;

        #region Данные об интегрируемых функциях
        private int num = 0;

        // Изображение функций
        private readonly Bitmap[] images = new Bitmap[] {
            new Bitmap("ex1.png"), new Bitmap("ex2.png"), new Bitmap("ex3.png"),
            new Bitmap("ex4.png"), new Bitmap("ex5.png"), new Bitmap("ex6.png")
        };

        // Пределы интегрирования
        private readonly double[,] limits = new double[,] {
            { 0, 1 }, { -1.0, 1.0 }, { 0.001, 11.0 }, { 0.0, 1.0 }, { 0.0, 1.0 }, { -1.0, 1.0 }
        };

        // Ссылки на функции
        private readonly Mydel[] delegates = new Mydel[] {
            new Mydel(arg => Math.Exp(-Math.Pow(arg, 2)) / Math.Sqrt(Math.PI)),
            new Mydel(arg => 1/(1+25*(arg*arg))),
            new Mydel(arg => Math.Sin(arg) / arg),
            new Mydel(arg => Math.Sin(100 * arg)),
            new Mydel(arg => 1 / (Math.Pow(arg - 0.3, 2) + 0.001)),
            new Mydel(arg => 1 / (Math.Abs(arg) + 0.01)),
        };
        #endregion

        public MainPresenter(IMainForm mainForm, MyModel myModel)
        {
            this.mainForm = mainForm;
            this.myModel = myModel;

            this.mainForm.FormuleClick += MainForm_FormuleClick;
            this.mainForm.CalculateButton += MainForm_CalculateButton;

            MainForm_FormuleClick();
        }

        private void MainForm_CalculateButton(object sender, EventArgs e)
        {
            var (A, B) = mainForm.GetLimits;
            var (Nmin, Nmax, eps) = mainForm.GetSimpson;
            var (numberOfShots, series, isVisualize) = mainForm.GetMonteKarlo;
            double adptiveEps = mainForm.GetAdaptive;

            var simpson = myModel.SimpsonNew(A, B, Nmin, Nmax, eps);

            mainForm.SetStringTable(1, 0, simpson.result.ToString());           
            mainForm.SetStringTable(2, 0, simpson.runge.ToString());
            mainForm.SetStringTable(3, 0, simpson.real_n.ToString());

            var adaptive = myModel.AdaptiveSimpson(A, B, adptiveEps);
            mainForm.SetStringTable(1, 2, adaptive.result.ToString());
            mainForm.SetStringTable(2, 2, adaptive.runge.ToString());

            var (area, accuracy, k) = myModel.MonteKarloMethod(A, B, numberOfShots, series);

            using (diagram = new FunctionDiagram(myModel.Function, A, B, myModel.CoordPoints, isVisualize))
            {   
                mainForm.SetStringTable(1, 1, area.ToString());
                mainForm.SetStringTable(2, 1, accuracy.ToString());
                mainForm.SetStringTable(3, 1, k.ToString() + " - цель");

                diagram.Run(30);
            }
        }

        private void MainForm_FormuleClick()
        {
            if (num >= images.Length) num = 0;
            mainForm.SetPictureAction?.Invoke(images[num], limits[num, 0], limits[num, 1]);

            myModel.Function = delegates[num];
            //myModel.Function = func;

            num++;
        }

        private double func(double arg)
        {
            return Math.Sqrt(arg);
        }
    }
}
