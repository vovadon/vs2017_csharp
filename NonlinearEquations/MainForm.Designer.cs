namespace NonlinearEquations
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chordBut = new System.Windows.Forms.Button();
            this.chordEpsTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chordB_TB = new System.Windows.Forms.TextBox();
            this.chordA_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.raphsonBut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.raphsonEps_TB = new System.Windows.Forms.TextBox();
            this.raphsonY_TB = new System.Windows.Forms.TextBox();
            this.raphsonX_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxY_TB = new System.Windows.Forms.TextBox();
            this.minY_TB = new System.Windows.Forms.TextBox();
            this.maxX_TB = new System.Windows.Forms.TextBox();
            this.minX_TB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chordBut);
            this.groupBox1.Controls.Add(this.chordEpsTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chordB_TB);
            this.groupBox1.Controls.Add(this.chordA_TB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод секущих";
            // 
            // chordBut
            // 
            this.chordBut.Location = new System.Drawing.Point(439, 18);
            this.chordBut.Name = "chordBut";
            this.chordBut.Size = new System.Drawing.Size(137, 50);
            this.chordBut.TabIndex = 6;
            this.chordBut.Text = "Вычислить";
            this.chordBut.UseVisualStyleBackColor = true;
            this.chordBut.Click += new System.EventHandler(this.ChordBut_Click);
            // 
            // chordEpsTB
            // 
            this.chordEpsTB.Location = new System.Drawing.Point(346, 33);
            this.chordEpsTB.Name = "chordEpsTB";
            this.chordEpsTB.Size = new System.Drawing.Size(87, 21);
            this.chordEpsTB.TabIndex = 5;
            this.chordEpsTB.Text = "1E-3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Требуемая точность:";
            // 
            // chordB_TB
            // 
            this.chordB_TB.Location = new System.Drawing.Point(129, 33);
            this.chordB_TB.Name = "chordB_TB";
            this.chordB_TB.Size = new System.Drawing.Size(75, 21);
            this.chordB_TB.TabIndex = 3;
            // 
            // chordA_TB
            // 
            this.chordA_TB.Location = new System.Drawing.Point(35, 33);
            this.chordA_TB.Name = "chordA_TB";
            this.chordA_TB.Size = new System.Drawing.Size(58, 21);
            this.chordA_TB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(99, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "B: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "A: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.raphsonBut);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.raphsonEps_TB);
            this.groupBox2.Controls.Add(this.raphsonY_TB);
            this.groupBox2.Controls.Add(this.raphsonX_TB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Метод Ньютона-Рафсона";
            // 
            // raphsonBut
            // 
            this.raphsonBut.Location = new System.Drawing.Point(439, 31);
            this.raphsonBut.Name = "raphsonBut";
            this.raphsonBut.Size = new System.Drawing.Size(137, 50);
            this.raphsonBut.TabIndex = 7;
            this.raphsonBut.Text = "Вичислить";
            this.raphsonBut.UseVisualStyleBackColor = true;
            this.raphsonBut.Click += new System.EventHandler(this.RaphsonBut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Требуемая точность: ";
            // 
            // raphsonEps_TB
            // 
            this.raphsonEps_TB.Location = new System.Drawing.Point(346, 46);
            this.raphsonEps_TB.Name = "raphsonEps_TB";
            this.raphsonEps_TB.Size = new System.Drawing.Size(87, 21);
            this.raphsonEps_TB.TabIndex = 5;
            this.raphsonEps_TB.Text = "1E-3";
            // 
            // raphsonY_TB
            // 
            this.raphsonY_TB.Location = new System.Drawing.Point(129, 46);
            this.raphsonY_TB.Name = "raphsonY_TB";
            this.raphsonY_TB.Size = new System.Drawing.Size(75, 21);
            this.raphsonY_TB.TabIndex = 4;
            this.raphsonY_TB.Text = "0";
            // 
            // raphsonX_TB
            // 
            this.raphsonX_TB.Location = new System.Drawing.Point(32, 46);
            this.raphsonX_TB.Name = "raphsonX_TB";
            this.raphsonX_TB.Size = new System.Drawing.Size(61, 21);
            this.raphsonX_TB.TabIndex = 3;
            this.raphsonX_TB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(100, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Начальное приближение";
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunc.Legends.Add(legend1);
            this.chartFunc.Location = new System.Drawing.Point(600, 27);
            this.chartFunc.Name = "chartFunc";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartFunc.Series.Add(series1);
            this.chartFunc.Series.Add(series2);
            this.chartFunc.Size = new System.Drawing.Size(528, 482);
            this.chartFunc.TabIndex = 2;
            this.chartFunc.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Для смены уравнения или системы уравнений щелкните по рисунку";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 112);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(306, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 112);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxY_TB);
            this.groupBox3.Controls.Add(this.minY_TB);
            this.groupBox3.Controls.Add(this.maxX_TB);
            this.groupBox3.Controls.Add(this.minX_TB);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 95);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Интервалы осей координат";
            // 
            // maxY_TB
            // 
            this.maxY_TB.Location = new System.Drawing.Point(306, 63);
            this.maxY_TB.Name = "maxY_TB";
            this.maxY_TB.Size = new System.Drawing.Size(158, 21);
            this.maxY_TB.TabIndex = 9;
            this.maxY_TB.Text = "5";
            // 
            // minY_TB
            // 
            this.minY_TB.Location = new System.Drawing.Point(306, 38);
            this.minY_TB.Name = "minY_TB";
            this.minY_TB.Size = new System.Drawing.Size(158, 21);
            this.minY_TB.TabIndex = 8;
            this.minY_TB.Text = "-5";
            // 
            // maxX_TB
            // 
            this.maxX_TB.Location = new System.Drawing.Point(46, 63);
            this.maxX_TB.Name = "maxX_TB";
            this.maxX_TB.Size = new System.Drawing.Size(158, 21);
            this.maxX_TB.TabIndex = 7;
            this.maxX_TB.Text = "5";
            // 
            // minX_TB
            // 
            this.minX_TB.Location = new System.Drawing.Point(46, 38);
            this.minX_TB.Name = "minX_TB";
            this.minX_TB.Size = new System.Drawing.Size(158, 21);
            this.minX_TB.TabIndex = 6;
            this.minX_TB.Text = "-5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Max: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Min: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Max: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Min: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(266, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "По оси Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "По оси X";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 427);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(582, 82);
            this.dataGridView.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 521);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chartFunc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение нелинейных уравнений и систем";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chordBut;
        private System.Windows.Forms.TextBox chordEpsTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chordB_TB;
        private System.Windows.Forms.TextBox chordA_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button raphsonBut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox raphsonEps_TB;
        private System.Windows.Forms.TextBox raphsonY_TB;
        private System.Windows.Forms.TextBox raphsonX_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox maxX_TB;
        private System.Windows.Forms.TextBox minX_TB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox maxY_TB;
        private System.Windows.Forms.TextBox minY_TB;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

