using System;
using System.Collections.Generic;

namespace NonlinearEquations
{
    public class Chords
    {
        public Func<double, double> f { get; set; }
        public double x0 { get; set; }
        public double x1 { get; set; }
        public double e { get; set; }
        public double n { get; set; }
        public double[] result { get; set; }
        private List<double> l { get; set; }

        public Chords(Func<double, double> f, double x0, double x1, double e, double n = 100)
        {
            this.f = f;
            this.e = e;
            this.n = n;
            this.x0 = x0;
            this.x1 = x1;
            l = new List<double>();
        }

        public void Calc()
        {
            double h = (x1 - x0) / n;
            l.Clear();

            for (double i = x0; i < x1; i += h)
                if (f(i) * f(i + h) <= 0)
                    l.Add(Calc(f, i + h, h, e));

            result = new double[l.Count];
            int counter = 0;
            foreach (double i in l)
            {
                result[counter] = i;
                counter++;
            }
        }

        private double Calc(Func<double, double> f, double x0, double x1, double e)
        {
            double xn = 0;
            while (Math.Abs(x1 - x0) > e)
            {
                xn = x0 - ((f(x0) * (x1 - x0)) / (f(x1) - f(x0)));
                x0 = x1; x1 = xn;
            }
            return xn;
        }
    }
}