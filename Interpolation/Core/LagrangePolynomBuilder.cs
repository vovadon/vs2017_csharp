using System;

namespace Interpolation.Core
{
    public class LagrangePolynomBuilder
    {
        /// <summary>
        /// Создает новый экземпляр класса
        /// </summary>
        /// <param name="x">Массив из координат x</param>
        /// <param name="y">Массив из координат y</param>
        public LagrangePolynomBuilder(double[] x, double[] y)
        {
            if (x.Length != y.Length)
                throw new Exception("x.Length != y.Length");

            this.x = x;
            this.y = y;

            // Степень полинома
            n = x.Length;

            coefficients = new double[y.Length];

            // Вычисление коэффициентов для полинома
            CalculatePolynomial();
        }

        /// <summary>
        /// Вычисляет значения интерполированной функции в выбранной точке
        /// </summary>
        /// <param name="arg">Точка, в которой нужно вычислить значение функции</param>
        /// <returns>Возвращает значение многочлена Лагранжа</returns>
        public double Lagrange(double arg)
        {
            double result = 0d, accumulator;

            for (int i = 0; i < coefficients.Length; i++)
            {
                accumulator = 1d;
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;

                    accumulator *= (arg - x[j]);
                }

                accumulator *= coefficients[i];
                result += accumulator;
            }

            return result;
        }

        private void CalculatePolynomial()
        {
            double accumulator;

            for (int i = 0; i < coefficients.Length; i++)
            {
                accumulator = 1d;
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;

                    accumulator *= (x[i] - x[j]);
                }

                coefficients[i] = y[i] / accumulator;
            }
        }

        private readonly int n;
        private readonly double[] x;
        private readonly double[] y;
        private readonly double[] coefficients;
    }
}
