using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonlinearEquations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;

            pictureBox1.Click += PictureBox1_Click;
            pictureBox2.Click += PictureBox2_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PictureBox1_Click(this, EventArgs.Empty);
            PictureBox2_Click(this, EventArgs.Empty);

            // DataGridViev
            dataGridView.Columns.Add("method", "Метод");
            dataGridView.Columns.Add("result", "Решение");

            dataGridView.Rows.Add("Секущих");
            dataGridView.Rows.Add("Ньютона-Рафсона");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ImageManager.NextStateEquations();

            pictureBox1.Image = ImageManager.GetEquationsImage;
            chordA_TB.Text = ImageManager.GetEquationLimits.A.ToString();
            chordB_TB.Text = ImageManager.GetEquationLimits.B.ToString();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            ImageManager.NextStateSystem();

            pictureBox2.Image = ImageManager.GetSystemImage;
        }

        private void ChordBut_Click(object sender, EventArgs e)
        {
            chordsMethod = new Chords(ImageManager.GetFunction, GetLimitsChord.A, GetLimitsChord.B, GetChordAccurancy);
            chordsMethod.Calc();

            DrawChart(ImageManager.GetFunction, 0, "Секущих");

            var res = chordsMethod.result.FirstOrDefault();
            dataGridView[1, 0].Value = res.ToString();
        }

        private void RaphsonBut_Click(object sender, EventArgs e)
        {
            raphson = new NewtonRaphson(ImageManager.GetFirstSystemEquations, ImageManager.GetSecondSystemEquations);
            var res = raphson.Calculate(GetRaphsonAccurancy, GetRaphson.x, GetRaphson.y);

            DrawChart(ImageManager.GetSystemFunctions.f1, 0, "Первая функция системы");
            DrawChart(ImageManager.GetSystemFunctions.f2, 1, "Вторая функция системы");

            var resStr = String.Format("X: {0:f12}; Y: {1:f12}", res[0], res[1]);
            dataGridView[1, 1].Value = resStr;
        }

        private void DrawChart(Func<double, double> func, int seriesIndex, string name)
        {
            chartFunc.Series[seriesIndex].Points.Clear();
            //if (seriesIndex == 0)
            //    chartFunc.Series[0].Points.Clear();

            var (Xmin, Xmax, Ymin, Ymax) = GetInterval();

            chartFunc.ChartAreas[0].AxisX.Minimum = Xmin;
            chartFunc.ChartAreas[0].AxisX.Maximum = Xmax;
            chartFunc.ChartAreas[0].AxisY.Minimum = Ymin;
            chartFunc.ChartAreas[0].AxisY.Maximum = Ymax;

            chartFunc.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartFunc.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartFunc.ChartAreas[0].AxisX.Crossing = 0;
            chartFunc.ChartAreas[0].AxisY.Crossing = 0;

            chartFunc.Series[seriesIndex].IsVisibleInLegend = true;
            chartFunc.Series[seriesIndex].Name = name;

            double h = (Xmax - Xmin) / 100;
            for (var xi = Xmin; xi <= Xmax; xi += h)
            {
                chartFunc.Series[seriesIndex].Points.AddXY(xi, func(xi));
            }
        }

        public (double Xmin, double Xmax, double Ymin, double Ymax) GetInterval()
        {
            double Xmin = Double.Parse(minX_TB.Text);
            double Xmax = Double.Parse(maxX_TB.Text);
            double Ymin = Double.Parse(minY_TB.Text);
            double Ymax = Double.Parse(maxY_TB.Text);

            return (Xmin, Xmax, Ymin, Ymax);
        }

        public (double A, double B) GetLimitsChord
        {
            get
            {
                double a = Double.Parse(chordA_TB.Text);
                double b = Double.Parse(chordB_TB.Text);

                return (a, b);
            }
        }

        public (double x, double y) GetRaphson
        {
            get
            {
                double x = Double.Parse(raphsonX_TB.Text);
                double y = Double.Parse(raphsonY_TB.Text);

                return (x, y);
            }
        }

        public double GetChordAccurancy => Double.Parse(chordEpsTB.Text);

        public double GetRaphsonAccurancy => Double.Parse(raphsonEps_TB.Text);

        private Chords chordsMethod;
        private NewtonRaphson raphson;
    }
}
