using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interpolation.Core;

namespace Interpolation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void SetCountBut_Click(object sender, EventArgs e)
        {
            int N = GetCountVertex;
            var dataTable = new DataTable();

            for (int i = 0; i < N + 1; i++)
            {
                var column = new DataColumn();
                //column.ColumnName = (i - 1).ToString();
                dataTable.Columns.Add();
            }
            
            dataTable.Rows.Add("X");
            dataTable.Rows.Add("Y");
            
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Width = 20;
        }
        
        private void LagrangeDrawBut_Click(object sender, EventArgs e)
        {
            int N = GetCountVertex;

            double[] x = new double[N];
            double[] y = new double[N];

            for (int i = 0; i < N; i++)
                x[i] = Convert.ToDouble(dataGridView1[i + 1, 0].Value);

            for (int i = 0; i < N; i++)
                y[i] = Convert.ToDouble(dataGridView1[i + 1, 1].Value);

            lagrangeBuilder = new LagrangePolynomBuilder(x, y);
            
            chart1.Series[0].Points.Clear();
            chart1.Series[0].LegendText = "Lagrange";

            for (double arg = x.Min(); arg <= x.Max(); arg += 0.5)
                chart1.Series[0].Points.AddXY(arg, lagrangeBuilder.Lagrange(arg));

            chart1.Series[1].LegendText = "Vertex";
            chart1.Series[1].Color = Color.Red;

            for (int i = 0; i < N; i++)
                chart1.Series[1].Points.AddXY(x[i], y[i]);
        }

        private void AutoFillBut_Click(object sender, EventArgs e)
        {
            double[] y = { 0.55, 0.7, 0.77, 0.82, 0.85 };

            for (int i = 0; i < GetCountVertex; i++)
                dataGridView1[i + 1, 0].Value = i + 1;

            for (int i = 0; i < GetCountVertex; i++)
                dataGridView1[i + 1, 1].Value = y[i];
        }

        private void SelectFuncBut_Click(object sender, EventArgs e)
        {
            if (funcComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберете функцию из списка!");
                return;
            }

            switch (funcComboBox.SelectedIndex)
            {
                case 0:
                    function = arg => Math.Exp(arg);
                    break;
                case 1:
                    function = arg => Math.Exp(-arg);
                    break;
                case 2:
                    function = arg => Math.Sinh(arg);
                    break;
                case 3:
                    function = arg => Math.Cosh(arg);
                    break;
                case 4:
                    function = arg => Math.Sin(arg);
                    break;
                case 5:
                    function = arg => Math.Cos(arg);
                    break;
                case 6:
                    function = arg => Math.Log(arg, Math.E);
                    break;
            }
        }

        private void CubSplineBut_Click(object sender, EventArgs e)
        {
            if (function == null)
            {
                MessageBox.Show("Выберете функцию из списка!");
                return;
            }

            var x = new List<double>();
            var y = new List<double>();

            for (var i = GetXMin; i <= GetXMax; i += GetStep)
            {
                x.Add(i);
                y.Add(function(i));
            }

            cubicSpline = new CubicSpline(x.ToArray(), y.ToArray());
            
            var res = cubicSpline.Interpolate(GetPoint).ToString();
            fldResult.Text = "Результат вычисления: " + res;
        }

        public int GetCountVertex => Int32.Parse(countVrtxTB.Text);

        public double GetXMin => Double.Parse(xMinTB.Text);

        public double GetXMax => Double.Parse(xMaxTB.Text);

        public double GetStep => Double.Parse(stepTB.Text);

        public double GetPoint => Double.Parse(pointTB.Text);

        private LagrangePolynomBuilder lagrangeBuilder;
        private CubicSpline cubicSpline;
        private Func<double, double> function;
    }
}
