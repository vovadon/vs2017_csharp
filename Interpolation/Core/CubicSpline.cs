using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation.Core
{
    public class CubicSpline
    {
        /// <summary>
        /// Создает новый экземпляр класса
        /// </summary>
        /// <param name="x">Массив аргументов функции</param>
        /// <param name="y">Массив значений функции при x[i] аргументе</param>
        public CubicSpline(double[] x, double[] y)
        {
            if (x.Length != y.Length)
                throw new Exception("x.Length != y.Length");

            this.x = x;
            this.y = y;

            n = x.Length;

            BuildSpline();
        }

        private void BuildSpline()
        {
            double[] d = new double[n - 2];
            double[,] matrix = new double[n - 2, n - 2];

            // Вычисление коэффициентов матрицы 
            for (int i = 1, k = 0; i < n - 1; i++, k++)
            {
                double hi = x[i] - x[i - 1];
                double hi1 = x[i + 1] - x[i];

                for (int j = 1, m = 0; j < n - 1; j++, m++)
                {
                    if (i == j)
                        matrix[k, m] = (hi + hi1) / 3;
                    else if (j == i + 1)
                        matrix[k, m] = hi1 / 6;
                    else if (j == i - 1)
                        matrix[k, m] = hi / 6;
                }

                d[k] = (y[i + 1] - y[i]) / hi1 - (y[i] - y[i - 1]) / hi;
            }

            // Решием систему методом Гаусса
            // Здесь можно было применить метод прогонки
            var gj = new GaussJordan(matrix, d);
            gj.Calculate();

            // Т.к. m[0] = m[n] = 0, добавляем нуль в начало и в конец списка
            List<double> results = new List<double>();
            results.Add(0.0);

            results.AddRange(gj.GetResult);
            results.Add(0.0);

            m = results.ToArray();
        }

        /// <summary>
        /// Вычисляет значения интерполированной функции в выбранной точке
        /// </summary>
        /// <param name="arg">Точка, в которой нужно вычислить значение функции</param>
        /// <returns>Возвращает значение интерполированной функции</returns>
        public double Interpolate(double arg)
        {
            int n = x.Length;

            int i = 0;
            int j = n - 1;

            //Производим бинарный поиск нужного участка
            while (i + 1 < j)
            {
                int k = i + (j - i) / 2;
                if (arg <= x[k])
                {
                    j = k;
                }
                else
                {
                    i = k;
                }
            }
            
            double xi_x = x[j] - arg;
            double x_xi1 = arg - x[j - 1];
            double hi = x[j] - x[j - 1];

            // Формула (4.8) из методички
            return xi_x / hi * y[j - 1] + x_xi1 / hi * y[j] + ((Math.Pow(xi_x, 3) - hi * hi * xi_x) * m[j - 1]) / (6 * hi) + ((Math.Pow(x_xi1, 3) - hi * hi * x_xi1) * m[j]) / (6 * hi);
        }

        private double[] m;

        private readonly int n;
        private readonly double[] x;
        private readonly double[] y;      
    } 
}
