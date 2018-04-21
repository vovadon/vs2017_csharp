namespace Integration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CalculateBut = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.formulePicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.simpsonGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monteKarloGroup = new System.Windows.Forms.GroupBox();
            this.numSeries = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numOfShots = new System.Windows.Forms.TextBox();
            this.visualizeMonteKarlo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sizeFormLbl = new System.Windows.Forms.Label();
            this.adaptiveGroup = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulePicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.simpsonGroupBox.SuspendLayout();
            this.monteKarloGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeries)).BeginInit();
            this.adaptiveGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateBut
            // 
            this.CalculateBut.Location = new System.Drawing.Point(15, 200);
            this.CalculateBut.Name = "CalculateBut";
            this.CalculateBut.Size = new System.Drawing.Size(288, 50);
            this.CalculateBut.TabIndex = 1;
            this.CalculateBut.Text = "Вычислить";
            this.CalculateBut.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(309, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(583, 238);
            this.dataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Для смены интеграла щелкните по рисунку";
            // 
            // formulePicture
            // 
            this.formulePicture.Location = new System.Drawing.Point(15, 38);
            this.formulePicture.Name = "formulePicture";
            this.formulePicture.Size = new System.Drawing.Size(288, 94);
            this.formulePicture.TabIndex = 6;
            this.formulePicture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пределы интегрирования";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1.Location = new System.Drawing.Point(39, 25);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 22);
            this.TextBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(145, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "B =";
            // 
            // TextBox2
            // 
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox2.Location = new System.Drawing.Point(179, 24);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 22);
            this.TextBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "A =";
            // 
            // simpsonGroupBox
            // 
            this.simpsonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpsonGroupBox.Controls.Add(this.textBox3);
            this.simpsonGroupBox.Controls.Add(this.textBox4);
            this.simpsonGroupBox.Controls.Add(this.textBox5);
            this.simpsonGroupBox.Controls.Add(this.label6);
            this.simpsonGroupBox.Controls.Add(this.label5);
            this.simpsonGroupBox.Controls.Add(this.label4);
            this.simpsonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpsonGroupBox.Location = new System.Drawing.Point(15, 263);
            this.simpsonGroupBox.Name = "simpsonGroupBox";
            this.simpsonGroupBox.Size = new System.Drawing.Size(877, 65);
            this.simpsonGroupBox.TabIndex = 8;
            this.simpsonGroupBox.TabStop = false;
            this.simpsonGroupBox.Text = "Формула Симпсона (парабола)";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(114, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "2";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(443, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "10000";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(771, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "1E-7";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(638, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Требуемая точность";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(332, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Разбиений (max)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Разбиений (min)";
            // 
            // monteKarloGroup
            // 
            this.monteKarloGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monteKarloGroup.Controls.Add(this.numSeries);
            this.monteKarloGroup.Controls.Add(this.label7);
            this.monteKarloGroup.Controls.Add(this.numOfShots);
            this.monteKarloGroup.Controls.Add(this.visualizeMonteKarlo);
            this.monteKarloGroup.Controls.Add(this.label8);
            this.monteKarloGroup.Controls.Add(this.sizeFormLbl);
            this.monteKarloGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monteKarloGroup.Location = new System.Drawing.Point(15, 334);
            this.monteKarloGroup.Name = "monteKarloGroup";
            this.monteKarloGroup.Size = new System.Drawing.Size(877, 65);
            this.monteKarloGroup.TabIndex = 9;
            this.monteKarloGroup.TabStop = false;
            this.monteKarloGroup.Text = "Метод Монте-Карло";
            // 
            // numSeries
            // 
            this.numSeries.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSeries.Location = new System.Drawing.Point(553, 27);
            this.numSeries.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSeries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeries.Name = "numSeries";
            this.numSeries.Size = new System.Drawing.Size(80, 21);
            this.numSeries.TabIndex = 5;
            this.numSeries.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(434, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Количество серий";
            // 
            // numOfShots
            // 
            this.numOfShots.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numOfShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfShots.Location = new System.Drawing.Point(771, 26);
            this.numOfShots.Name = "numOfShots";
            this.numOfShots.Size = new System.Drawing.Size(100, 21);
            this.numOfShots.TabIndex = 3;
            this.numOfShots.Text = "20000";
            // 
            // visualizeMonteKarlo
            // 
            this.visualizeMonteKarlo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visualizeMonteKarlo.AutoSize = true;
            this.visualizeMonteKarlo.Checked = true;
            this.visualizeMonteKarlo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.visualizeMonteKarlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visualizeMonteKarlo.Location = new System.Drawing.Point(179, 28);
            this.visualizeMonteKarlo.Name = "visualizeMonteKarlo";
            this.visualizeMonteKarlo.Size = new System.Drawing.Size(230, 19);
            this.visualizeMonteKarlo.TabIndex = 1;
            this.visualizeMonteKarlo.Text = "Визуализировать точки попадений";
            this.visualizeMonteKarlo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(639, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Количество бросков";
            // 
            // sizeFormLbl
            // 
            this.sizeFormLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sizeFormLbl.AutoSize = true;
            this.sizeFormLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeFormLbl.Location = new System.Drawing.Point(6, 29);
            this.sizeFormLbl.Name = "sizeFormLbl";
            this.sizeFormLbl.Size = new System.Drawing.Size(147, 15);
            this.sizeFormLbl.TabIndex = 0;
            this.sizeFormLbl.Text = "Размер формы 920*520";
            // 
            // adaptiveGroup
            // 
            this.adaptiveGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adaptiveGroup.Controls.Add(this.textBox7);
            this.adaptiveGroup.Controls.Add(this.label10);
            this.adaptiveGroup.Controls.Add(this.label9);
            this.adaptiveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adaptiveGroup.Location = new System.Drawing.Point(15, 405);
            this.adaptiveGroup.Name = "adaptiveGroup";
            this.adaptiveGroup.Size = new System.Drawing.Size(877, 65);
            this.adaptiveGroup.TabIndex = 10;
            this.adaptiveGroup.TabStop = false;
            this.adaptiveGroup.Text = "Адаптивная формула Симпсона";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(771, 25);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 2;
            this.textBox7.Text = "1E-7";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(638, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Требуемая точность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "с переменной плотностью разбиений";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 482);
            this.Controls.Add(this.adaptiveGroup);
            this.Controls.Add(this.monteKarloGroup);
            this.Controls.Add(this.simpsonGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formulePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.CalculateBut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Приближенное вычисление определенных интеграллов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulePicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.simpsonGroupBox.ResumeLayout(false);
            this.simpsonGroupBox.PerformLayout();
            this.monteKarloGroup.ResumeLayout(false);
            this.monteKarloGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeries)).EndInit();
            this.adaptiveGroup.ResumeLayout(false);
            this.adaptiveGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalculateBut;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox formulePicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox simpsonGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox monteKarloGroup;
        private System.Windows.Forms.TextBox numOfShots;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox visualizeMonteKarlo;
        private System.Windows.Forms.Label sizeFormLbl;
        private System.Windows.Forms.GroupBox adaptiveGroup;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numSeries;
        private System.Windows.Forms.Label label7;
    }
}

