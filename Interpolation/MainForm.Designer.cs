namespace Interpolation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lagrangeDrawBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoFillBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.setCountBut = new System.Windows.Forms.Button();
            this.countVrtxTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cubSplineBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectFuncBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stepTB = new System.Windows.Forms.TextBox();
            this.xMaxTB = new System.Windows.Forms.TextBox();
            this.xMinTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.funcComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pointTB = new System.Windows.Forms.TextBox();
            this.fldResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 160);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(465, 313);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 551);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lagrangeDrawBut);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Полином Лагранжа";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lagrangeDrawBut
            // 
            this.lagrangeDrawBut.Location = new System.Drawing.Point(167, 479);
            this.lagrangeDrawBut.Name = "lagrangeDrawBut";
            this.lagrangeDrawBut.Size = new System.Drawing.Size(150, 40);
            this.lagrangeDrawBut.TabIndex = 5;
            this.lagrangeDrawBut.Text = "Построить";
            this.lagrangeDrawBut.UseVisualStyleBackColor = true;
            this.lagrangeDrawBut.Click += new System.EventHandler(this.LagrangeDrawBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Интерполяционный многочлен Лагранжа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoFillBut);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.setCountBut);
            this.groupBox1.Controls.Add(this.countVrtxTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // autoFillBut
            // 
            this.autoFillBut.Location = new System.Drawing.Point(334, 26);
            this.autoFillBut.Name = "autoFillBut";
            this.autoFillBut.Size = new System.Drawing.Size(125, 23);
            this.autoFillBut.TabIndex = 4;
            this.autoFillBut.Text = "Автозаполнение";
            this.autoFillBut.UseVisualStyleBackColor = true;
            this.autoFillBut.Click += new System.EventHandler(this.AutoFillBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 73);
            this.dataGridView1.TabIndex = 3;
            // 
            // setCountBut
            // 
            this.setCountBut.Location = new System.Drawing.Point(222, 26);
            this.setCountBut.Name = "setCountBut";
            this.setCountBut.Size = new System.Drawing.Size(75, 23);
            this.setCountBut.TabIndex = 2;
            this.setCountBut.Text = "Задать";
            this.setCountBut.UseVisualStyleBackColor = true;
            this.setCountBut.Click += new System.EventHandler(this.SetCountBut_Click);
            // 
            // countVrtxTB
            // 
            this.countVrtxTB.Location = new System.Drawing.Point(141, 27);
            this.countVrtxTB.Name = "countVrtxTB";
            this.countVrtxTB.Size = new System.Drawing.Size(75, 21);
            this.countVrtxTB.TabIndex = 1;
            this.countVrtxTB.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество вершин: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Кубический сплайн";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fldResult);
            this.groupBox3.Controls.Add(this.pointTB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cubSplineBut);
            this.groupBox3.Location = new System.Drawing.Point(6, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 95);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Значение сплайна в точке";
            // 
            // cubSplineBut
            // 
            this.cubSplineBut.Location = new System.Drawing.Point(354, 30);
            this.cubSplineBut.Name = "cubSplineBut";
            this.cubSplineBut.Size = new System.Drawing.Size(106, 21);
            this.cubSplineBut.TabIndex = 0;
            this.cubSplineBut.Text = "Вычислить";
            this.cubSplineBut.UseVisualStyleBackColor = true;
            this.cubSplineBut.Click += new System.EventHandler(this.CubSplineBut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectFuncBut);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stepTB);
            this.groupBox2.Controls.Add(this.xMaxTB);
            this.groupBox2.Controls.Add(this.xMinTB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.funcComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 106);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор функции";
            // 
            // selectFuncBut
            // 
            this.selectFuncBut.Location = new System.Drawing.Point(296, 29);
            this.selectFuncBut.Name = "selectFuncBut";
            this.selectFuncBut.Size = new System.Drawing.Size(93, 23);
            this.selectFuncBut.TabIndex = 8;
            this.selectFuncBut.Text = "Выбрать";
            this.selectFuncBut.UseVisualStyleBackColor = true;
            this.selectFuncBut.Click += new System.EventHandler(this.SelectFuncBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Шаг h";
            // 
            // stepTB
            // 
            this.stepTB.Location = new System.Drawing.Point(358, 74);
            this.stepTB.Name = "stepTB";
            this.stepTB.Size = new System.Drawing.Size(102, 21);
            this.stepTB.TabIndex = 6;
            this.stepTB.Text = "0,04";
            // 
            // xMaxTB
            // 
            this.xMaxTB.Location = new System.Drawing.Point(206, 74);
            this.xMaxTB.Name = "xMaxTB";
            this.xMaxTB.Size = new System.Drawing.Size(100, 21);
            this.xMaxTB.TabIndex = 5;
            this.xMaxTB.Text = "1,2";
            // 
            // xMinTB
            // 
            this.xMinTB.Location = new System.Drawing.Point(52, 74);
            this.xMinTB.Name = "xMinTB";
            this.xMinTB.Size = new System.Drawing.Size(100, 21);
            this.xMinTB.TabIndex = 4;
            this.xMinTB.Text = "1,0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "X max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "X min";
            // 
            // funcComboBox
            // 
            this.funcComboBox.FormattingEnabled = true;
            this.funcComboBox.Items.AddRange(new object[] {
            "e^x",
            "e^-x",
            "sh(x)",
            "ch(x)",
            "sin(x)",
            "cos(x)",
            "ln(x)"});
            this.funcComboBox.Location = new System.Drawing.Point(136, 30);
            this.funcComboBox.Name = "funcComboBox";
            this.funcComboBox.Size = new System.Drawing.Size(154, 23);
            this.funcComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выберете функцию ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Значение кубического спайлна в точке ";
            // 
            // pointTB
            // 
            this.pointTB.Location = new System.Drawing.Point(248, 30);
            this.pointTB.Name = "pointTB";
            this.pointTB.Size = new System.Drawing.Size(100, 21);
            this.pointTB.TabIndex = 2;
            this.pointTB.Text = "1,05";
            // 
            // fldResult
            // 
            this.fldResult.AutoSize = true;
            this.fldResult.Location = new System.Drawing.Point(7, 66);
            this.fldResult.Name = "fldResult";
            this.fldResult.Size = new System.Drawing.Size(147, 15);
            this.fldResult.TabIndex = 3;
            this.fldResult.Text = "Результат вычисления: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 575);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерполяция и аппроксимация";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button setCountBut;
        private System.Windows.Forms.TextBox countVrtxTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lagrangeDrawBut;
        private System.Windows.Forms.Button autoFillBut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stepTB;
        private System.Windows.Forms.TextBox xMaxTB;
        private System.Windows.Forms.TextBox xMinTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox funcComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cubSplineBut;
        private System.Windows.Forms.Button selectFuncBut;
        private System.Windows.Forms.TextBox pointTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fldResult;
    }
}

