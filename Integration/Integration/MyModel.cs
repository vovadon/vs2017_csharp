using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{   
    public delegate double Mydel(double arg);

    // Этот класс хранит в себе бизнес-логику приложения
    public class MyModel
    {
        /// <summary>
        /// Реализация метода Симпсона
        /// </summary>
        /// <param name="a">Нижний предел интегрирования</param>
        /// <param name="b">Верхний предел интегрирования</param>
        /// <param name="Nmin">Минимальное количество разбиений</param>
        /// <param name="Nmax">Максимальное количество разбиений</param>
        /// <param name="eps">Требуемая точность</param>
        /// <returns>Возвращает кортеж из результата, достигнутой точности и реального числа разбиений</returns>
        public (double result, double runge, int real_n) SimpsonNew(double a, double b, int Nmin, int Nmax, double eps = 0.0001)
        {          
            double s = Function(a) + Function(b);
            double v; // сумма значений функции при нечетных i
            double p; // сумма значений функции при четных i
            double Jn = 0, J2n = 0; // предыдущее и текущее вычисления

            int real_N = Nmin;
            double runge = 1;
            for (int N = Nmin; (runge > eps) && (N <= Nmax); N *= 2)
            {
                v = p = 0;
                Jn = J2n;

                double h = (b - a) / N; // шаг интегрирования

                double xi = a + h;
                while (xi < b)
                {
                    v += Function(xi); // значения с нечетными индексами
                    xi += 2 * h;
                }

                xi = a + 2 * h;
                while (xi < b - h)
                {
                    p += Function(xi); // значения с четными индексами
                    xi += 2 * h;
                }

                J2n = h / 3 * (s + 2 * p + 4 * v);
                runge = Math.Abs(J2n - Jn) / 15;
                real_N = N;
            }
            return (J2n, runge, real_N);
        }

        /// <summary>
        /// Адаптивный метод Симпсона
        /// </summary>
        /// <param name="a">Нижний предел интегрирования</param>
        /// <param name="b">Верхний предел интегрирования</param>
        /// <param name="eps">Требуемая точность</param>
        /// <returns></returns>
        public (double result, double runge) AdaptiveSimpson(double a, double b, double eps)
        {
            double accumulator = 0;
            double x1 = a, x2 = b;

            double s2, s4, h, runge;
            while (true)
            {
                s2 = Simpson(x1, x2, 2);
                s4 = Simpson(x1, x2, 4);

                runge = Math.Abs(s4 - s2) / 15;

                if (runge < eps)
                    if (x2 == b)
                    {
                        accumulator += s4;
                        break;
                    }
                    else
                    {
                        accumulator += s4;
                        h = x2 - x1;
                        x1 = x2; 
                        x2 += 2 * h;

                        if (x2 + 2 * h > b)
                            if (x2 + h > b)
                                x2 = b;
                            else x2 += h;
                        else
                            x2 += 2 * h;
                    }
                else
                    x2 = (x2 - x1) / 2 + x1;
            }
            return (accumulator, runge);
        }

        /// <summary>
        /// Упрощенная реализация метода Симпсона
        /// </summary>
        /// <param name="a">Нижний предел интегрирования</param>
        /// <param name="b">Верхний предел интегрирования</param>
        /// <param name="N">Количество разбиений</param>
        private double Simpson(double a, double b, int N)
        {
            double p = 0, v = 0;
            double h = (b - a) / N;
            double s = Function(a) + Function(b);

            double xi = a + h;
            while (xi < b)
            {
                v += Function(xi); // значения с нечетными индексами
                xi += 2 * h;
            }

            xi = a + 2 * h;
            while (xi < b - h)
            {
                p += Function(xi); // значения с четными индексами
                xi += 2 * h;
            }

            return h / 3 * (s + 2 * p + 4 * v);
        }

        public (double area, double accuracy, int k) MonteKarloMethod(double A, double B, int numOfShots, int series)
        {
            int k = 0;
            double y;
            double min = 0d, max = 0d;
            double sumOfSeries = 0, sumOfSquares = 0;

            var rnd = new Random();
            CoordPoints = new Point[numOfShots];

            /* Поиск максимума и минимума функции */
            for (double x = A; x < B; x += 0.01d)
            {
                double xi = Function.Invoke(x);

                if (xi > max) max = xi;
                if (xi < min) min = xi;
            }

            double Srect = (B - A) * (max - min); // Площадь прямоугольника

            /* Метод Монте-Карло */
            for (int cycle = 0; cycle < series; cycle++)
            {
                k = 0;

                for (int i = 0; i < numOfShots; i++)
                {
                    CoordPoints[i].X = rnd.NextDouble(A, B);
                    CoordPoints[i].Y = rnd.NextDouble(min, max);

                    y = Function(CoordPoints[i].X);

                    if (y > 0.0 && (CoordPoints[i].Y <= y && CoordPoints[i].Y > 0.0))
                    {
                        k++;
                        CoordPoints[i].InFunction = true;
                    }
                    else if (y < 0.0 && (CoordPoints[i].Y >= y && CoordPoints[i].Y < 0.0))
                    {
                        k--;
                        CoordPoints[i].InFunction = true;
                    }
                }

                sumOfSeries += Srect * k / numOfShots;
                sumOfSquares += Math.Pow(Srect * k / numOfShots, 2);
            }

            double Sk = sumOfSeries / series;
            double Sk_Squares = sumOfSquares / series;

            return (Sk, Math.Sqrt(Sk_Squares - Sk * Sk), k);
        }

        public Mydel Function { get; set; }

        public Point[] CoordPoints { get; private set; }
    }

    public static class RandomExtensions
    {
        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}
