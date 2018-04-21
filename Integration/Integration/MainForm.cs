using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration
{
    public delegate void SetPicture(Bitmap image, double a, double b);

    internal interface IMainForm
    {
        event EventHandler CalculateButton;
        event Action FormuleClick;

        SetPicture SetPictureAction { get; } // Возвращает делегат для установки нового изображения в PictureBox

        (double A, double B) GetLimits { get; }
        (int Nmin, int Nmax, double eps) GetSimpson { get; }
        (int numberOfShots, int series, bool isVisualize) GetMonteKarlo { get; }

        double GetAdaptive { get; }

        void SetStringTable(int columnIndex, int rowIndex, string str);
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            DataGridInitialize();

            Resize += MainForm_Resize;

            formulePicture.Click += FormulePicture_Click;
            CalculateBut.Click += CalculateBut_Click;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            sizeFormLbl.Text = $"Размер формы {Width}*{Height}";
        }

        private void DataGridInitialize()
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns.Add("formule", "Формула");
            dataGridView.Columns.Add("result", "Решение");
            dataGridView.Columns.Add("column3", "Абс. погрешность");
            dataGridView.Columns.Add("column4", "Фактическое число разбиений");

            dataGridView.Rows.Add("Симпсона (парабол)");
            dataGridView.Rows.Add("Монте-Карло");
            dataGridView.Rows.Add("Адаптивный метод");
        }

        private void SetPicture(Bitmap bitmap, double a, double b)
        {
            formulePicture.Image = bitmap;
            formulePicture.SizeMode = PictureBoxSizeMode.AutoSize;

            groupBox1.Controls[0].Text = a.ToString();
            groupBox1.Controls[2].Text = b.ToString();
        }

        #region Проброс событий

        public event EventHandler CalculateButton;
        public event Action FormuleClick;

        private void CalculateBut_Click(object sender, EventArgs e)
        {
            if (CalculateButton != null)
                CalculateButton(this, EventArgs.Empty);
        }

        private void FormulePicture_Click(object sender, EventArgs e)
        {
            FormuleClick?.Invoke();
        }
        #endregion

        #region IMainForm
        public (double A, double B) GetLimits
        {
            get
            {
                double first = Double.Parse(groupBox1.Controls[0].Text);
                double second = Double.Parse(groupBox1.Controls[2].Text);
                return (first, second);
            }
        }

        public (int Nmin, int Nmax, double eps) GetSimpson
        {
            get
            {
                int min = Int32.Parse(simpsonGroupBox.Controls[0].Text);
                int max = Int32.Parse(simpsonGroupBox.Controls[1].Text);
                double eps = Double.Parse(simpsonGroupBox.Controls[2].Text);
                return (min, max, eps);
            }
        }

        public (int numberOfShots, int series, bool isVisualize) GetMonteKarlo
        {
            get
            {
                int numShots = Int32.Parse(numOfShots.Text);
                int series = (int)numSeries.Value;
                bool visualize = visualizeMonteKarlo.Checked;
                return (numShots, series, visualize);
            }
        }

        public SetPicture SetPictureAction
        {
            get => SetPicture;
        }

        public double GetAdaptive
        {
            get => Double.Parse(adaptiveGroup.Controls[0].Text);
        }

        public void SetStringTable(int columnIndex, int rowIndex, string str)
        {
            dataGridView[columnIndex, rowIndex].Value = str;
        }
        #endregion
    }
}
