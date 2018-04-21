using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonlinearEquations
{
    internal static class ImageManager
    {
        #region Данные об интегрируемых функциях

        private static int firstIndexState = -1, secondIndexState = -1, tmp = -2;

        // Изображение функций
        private static readonly Bitmap[] equationsImages = new Bitmap[] {
            new Bitmap("ex1.png"), new Bitmap("ex2.png"), new Bitmap("ex3.png")
        };

        private static readonly Bitmap[] systemImages = new Bitmap[] {
            new Bitmap("SystemOfEquations1.png"), new Bitmap("SystemOfEquations2.png"), new Bitmap("SystemOfEquations3.png")
        };

        // Пределы интегрирования
        private static readonly double[,] limits = new double[,] {
            { -2.0, 3 }, { -2.0, 6.0 }, { -1, 2.0 }
        };

        // Ссылки на функции
        private static readonly Func<double, double>[] equations = new Func<double, double>[] {
            new Func<double, double>(arg => Math.Pow(Math.E, arg) - 2 * Math.Pow(arg - 1, 2)),
            new Func<double, double>(arg => Math.Pow(arg, 2) + 2 * arg - 3),
            new Func<double, double>(arg => arg - Math.Sin(2 * arg)),
        };

        private static readonly Func<double, double, double>[,] systemEquations = new Func<double, double, double>[,] {
            { new Func<double, double, double>((x, y) => 2 * y - Math.Cos(x + 1)), new Func<double, double, double>((x, y) => x - Math.Sin(y) - 0.4) },
            { new Func<double, double, double>((x, y) => Math.Cos(x - 1) + y - 0.5), new Func<double, double, double>((x, y) => x - Math.Cos(y) - 3) },
            { new Func<double, double, double>((x, y) => Math.Cos(x + 0.5) + y - 1), new Func<double, double, double>((x, y) => Math.Sin(y) - 2 * x - 2) },
        };

        private static readonly Func<double, double>[] systemFunc = new Func<double, double>[] {
            new Func<double, double>(arg => Math.Cos(arg + 1) / 2),
            new Func<double, double>(arg => Math.Asin(arg - 0.4)),
            new Func<double, double>(arg => 0.5 - Math.Cos(arg - 1)),
            new Func<double, double>(arg => Math.Acos(arg - 3)),
        };

        #endregion

        public static void NextStateEquations()
        {
            firstIndexState = firstIndexState == 1 ? 0 : firstIndexState + 1;
        }

        public static void NextStateSystem()
        {
            secondIndexState = secondIndexState == 1 ? 0 : secondIndexState + 1;
            tmp = tmp == 2 ? 0 : tmp + 2;
        }

        public static Bitmap GetEquationsImage => equationsImages[firstIndexState];

        public static Func<double, double> GetFunction => equations[firstIndexState];

        public static (double A, double B) GetEquationLimits => (limits[firstIndexState, 0], limits[firstIndexState, 1]);

        public static Bitmap GetSystemImage => systemImages[secondIndexState];

        public static Func<double, double, double> GetFirstSystemEquations => systemEquations[secondIndexState, 0];

        public static Func<double, double, double> GetSecondSystemEquations => systemEquations[secondIndexState, 1];

        public static (Func<double, double> f1, Func<double, double> f2) GetSystemFunctions => (systemFunc[tmp], systemFunc[tmp + 1]);
    }
}
