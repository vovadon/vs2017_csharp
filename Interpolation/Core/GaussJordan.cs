using System;

namespace Interpolation.Core
{
    public class GaussJordan
    {
        /// <summary>
        /// Создает новый экземпляр
        /// </summary>
        /// <param name="matrix">Матрица из коэффициентов системы линейных уравнений</param>
        /// <param name="b">Вектор-столбец свободных членов</param>
        public GaussJordan(double[,] matrix, double[] b)
        {
            this.matrix = matrix;
            this.b = b;

            x = new double[b.Length];
            r = new double[b.Length];
        }

        /// <summary>
        /// Вычисляет вектора решения и невязки. Вектор решения можно получить из свойства GetResult, невязки - GetDiscrepancy
        /// </summary>
        public void Calculate()
        {
            int columnsAndRow = matrix.GetLength(0);

            for (int i = 0; i < columnsAndRow - 1; i++)
            {
                SelectLeadElement(i);

                for (int j = i + 1; j < columnsAndRow; j++)
                {
                    double coeff = matrix[j, i] / matrix[i, i];

                    for (int k = i; k < columnsAndRow; k++)
                        matrix[j, k] = matrix[j, k] - coeff * matrix[i, k];

                    b[j] = b[j] - coeff * b[i];
                }
            }
            
            Reverse(); // Обратный ход
        }

        private void SelectLeadElement(int column) // Выбор ведущего элемента
        {
            int k = column; // Номер строки где находится максимальный элемент
            var maxElement = Math.Abs(matrix[k, column]);

            // Перебор всех элементов в столбце
            for (int i = column; i < matrix.GetLength(1); i++)
                if (Math.Abs(matrix[i, column]) > maxElement)
                {
                    maxElement = Math.Abs(matrix[i, column]);
                    k = i;
                }

            // т.к. матрица квадратная и column == row 
            if (k == column) // Если максимальный элемент находится в текущей строке, то выходим из метода
                return;

            var temp = b[column];
            b[column] = b[k];
            b[k] = temp;

            // Меняем строки местами
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                temp = matrix[column, i];
                matrix[column, i] = matrix[k, i];
                matrix[k, i] = temp;
            }
        }

        private void Reverse()
        {
            int lastIndex = x.Length - 1;

            x[lastIndex] = b[lastIndex] / matrix[lastIndex, lastIndex];
            r[lastIndex] = b[lastIndex] - matrix[lastIndex, lastIndex] * x[lastIndex];

            for (int i = lastIndex - 1; i >= 0; i--)
            {
                double accumulator = 0d;

                for (int j = i + 1; j <= lastIndex; j++)
                    accumulator += matrix[i, j] * x[j];

                x[i] = (b[i] - accumulator) / matrix[i, i];

                // Невязка
                r[i] = b[i] - (accumulator + matrix[i, i] * x[i]);
            }
        }

        public double[] GetResult => x;

        public double[] GetDiscrepancy => r;

        private readonly double[,] matrix = null; // Матрица системы
        private readonly double[] b = null; // Вектор-столбец свободных членов
        private readonly double[] x = null; // Решение
        private readonly double[] r = null; // Невязка
    }
}
