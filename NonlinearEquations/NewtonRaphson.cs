using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonlinearEquations
{
    public class NewtonRaphson
    {
        public NewtonRaphson(Func<double, double, double> func1, Func<double, double, double> func2)
        {
            this.func1 = func1;
            this.func2 = func2;
        }

        private double df(Func<double, double, double> func, double x1, double x2, byte value)
        {
            double dx = 0.001;
            switch (value)
            {
                case 1: return (func(x1 + dx, x2) - func(x1, x2)) / dx;
                case 2: return (func(x1, x2 + dx) - func(x1, x2)) / dx;
                default: return 0;
            }
        }

        public double[] Calculate(double eps, params double[] X)
        {
            double[,] W = new double[2, 2];     
            double[] F = new double[2];
            double[] dX = new double[2]; 

            do
            {
                W[0, 0] = df(func1, X[0], X[1], 1);
                W[0, 1] = df(func1, X[0], X[1], 2);
                W[1, 0] = df(func2, X[0], X[1], 1);
                W[1, 1] = df(func2, X[0], X[1], 2);

                F[0] = func1(X[0], X[1]);
                F[1] = func2(X[0], X[1]);
                
                F[1] = F[1] - (W[1, 0] / W[0, 0]) * F[0];
                W[1, 1] = W[1, 1] - (W[1, 0] / W[0, 0]) * W[0, 1];
                dX[1] = -F[1] / W[1, 1];
                dX[0] = (-F[0] - W[0, 1] * dX[1]) / W[0, 0];
                
                X[0] = X[0] + dX[0];
                X[1] = X[1] + dX[1];

            } while (Math.Abs(func1(X[0], X[1])) > eps || Math.Abs(func2(X[0], X[1])) > eps);

            return X;
        }

        private readonly Func<double, double, double> func1;
        private readonly Func<double, double, double> func2;
    }
}
