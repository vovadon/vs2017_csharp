namespace RsaEncryptor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numKeyLenght = new System.Windows.Forms.NumericUpDown();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.GeneratePQbutton = new System.Windows.Forms.Button();
            this.GenerateKeyButton = new System.Windows.Forms.Button();
            this.label_d = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.label_e = new System.Windows.Forms.Label();
            this.label_q = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label_p = new System.Windows.Forms.Label();
            this.groupBoxBefore = new System.Windows.Forms.GroupBox();
            this.textBoxBefore = new System.Windows.Forms.TextBox();
            this.groupBoxAfter = new System.Windows.Forms.GroupBox();
            this.textBoxAfter = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.OpenDocButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyLenght)).BeginInit();
            this.groupBoxBefore.SuspendLayout();
            this.groupBoxAfter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDecrypt);
            this.groupBox1.Controls.Add(this.radioEncrypt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Location = new System.Drawing.Point(106, 19);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(108, 17);
            this.radioDecrypt.TabIndex = 1;
            this.radioDecrypt.TabStop = true;
            this.radioDecrypt.Tag = "1";
            this.radioDecrypt.Text = "Расшифрование";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Location = new System.Drawing.Point(10, 19);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(90, 17);
            this.radioEncrypt.TabIndex = 0;
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.Tag = "0";
            this.radioEncrypt.Text = "Шифрование";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numKeyLenght);
            this.groupBox2.Controls.Add(this.textBox_N);
            this.groupBox2.Controls.Add(this.label_N);
            this.groupBox2.Controls.Add(this.GeneratePQbutton);
            this.groupBox2.Controls.Add(this.GenerateKeyButton);
            this.groupBox2.Controls.Add(this.label_d);
            this.groupBox2.Controls.Add(this.textBox_d);
            this.groupBox2.Controls.Add(this.textBox_e);
            this.groupBox2.Controls.Add(this.label_e);
            this.groupBox2.Controls.Add(this.label_q);
            this.groupBox2.Controls.Add(this.textBox_q);
            this.groupBox2.Controls.Add(this.textBox_p);
            this.groupBox2.Controls.Add(this.label_p);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры ключа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Длина ключа:";
            // 
            // numKeyLenght
            // 
            this.numKeyLenght.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numKeyLenght.Location = new System.Drawing.Point(314, 43);
            this.numKeyLenght.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numKeyLenght.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numKeyLenght.Name = "numKeyLenght";
            this.numKeyLenght.ReadOnly = true;
            this.numKeyLenght.Size = new System.Drawing.Size(84, 20);
            this.numKeyLenght.TabIndex = 12;
            this.numKeyLenght.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(32, 70);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(149, 20);
            this.textBox_N.TabIndex = 11;
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_N.Location = new System.Drawing.Point(7, 70);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(19, 18);
            this.label_N.TabIndex = 10;
            this.label_N.Text = "N";
            // 
            // GeneratePQbutton
            // 
            this.GeneratePQbutton.Location = new System.Drawing.Point(187, 19);
            this.GeneratePQbutton.Name = "GeneratePQbutton";
            this.GeneratePQbutton.Size = new System.Drawing.Size(120, 46);
            this.GeneratePQbutton.TabIndex = 9;
            this.GeneratePQbutton.Text = "Генерация P и Q";
            this.GeneratePQbutton.UseVisualStyleBackColor = true;
            // 
            // GenerateKeyButton
            // 
            this.GenerateKeyButton.Location = new System.Drawing.Point(186, 71);
            this.GenerateKeyButton.Name = "GenerateKeyButton";
            this.GenerateKeyButton.Size = new System.Drawing.Size(121, 69);
            this.GenerateKeyButton.TabIndex = 8;
            this.GenerateKeyButton.Text = "Генерация ключей";
            this.GenerateKeyButton.UseVisualStyleBackColor = true;
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_d.Location = new System.Drawing.Point(7, 94);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(19, 18);
            this.label_d.TabIndex = 7;
            this.label_d.Text = "D";
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(31, 96);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(149, 20);
            this.textBox_d.TabIndex = 6;
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(32, 122);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(75, 20);
            this.textBox_e.TabIndex = 5;
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_e.Location = new System.Drawing.Point(7, 122);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(18, 18);
            this.label_e.TabIndex = 4;
            this.label_e.Text = "E";
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_q.Location = new System.Drawing.Point(6, 45);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(20, 18);
            this.label_q.TabIndex = 3;
            this.label_q.Text = "Q";
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(31, 45);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(150, 20);
            this.textBox_q.TabIndex = 2;
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(31, 19);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(150, 20);
            this.textBox_p.TabIndex = 1;
            // 
            // label_p
            // 
            this.label_p.AutoSize = true;
            this.label_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_p.Location = new System.Drawing.Point(7, 19);
            this.label_p.Name = "label_p";
            this.label_p.Size = new System.Drawing.Size(18, 18);
            this.label_p.TabIndex = 0;
            this.label_p.Text = "P";
            // 
            // groupBoxBefore
            // 
            this.groupBoxBefore.Controls.Add(this.textBoxBefore);
            this.groupBoxBefore.Location = new System.Drawing.Point(12, 221);
            this.groupBoxBefore.Name = "groupBoxBefore";
            this.groupBoxBefore.Size = new System.Drawing.Size(410, 105);
            this.groupBoxBefore.TabIndex = 2;
            this.groupBoxBefore.TabStop = false;
            this.groupBoxBefore.Text = "Шифрование";
            // 
            // textBoxBefore
            // 
            this.textBoxBefore.Location = new System.Drawing.Point(6, 19);
            this.textBoxBefore.Multiline = true;
            this.textBoxBefore.Name = "textBoxBefore";
            this.textBoxBefore.Size = new System.Drawing.Size(398, 80);
            this.textBoxBefore.TabIndex = 0;
            // 
            // groupBoxAfter
            // 
            this.groupBoxAfter.Controls.Add(this.textBoxAfter);
            this.groupBoxAfter.Location = new System.Drawing.Point(12, 368);
            this.groupBoxAfter.Name = "groupBoxAfter";
            this.groupBoxAfter.Size = new System.Drawing.Size(410, 105);
            this.groupBoxAfter.TabIndex = 3;
            this.groupBoxAfter.TabStop = false;
            this.groupBoxAfter.Text = "Зашифрованный текст";
            // 
            // textBoxAfter
            // 
            this.textBoxAfter.Location = new System.Drawing.Point(6, 19);
            this.textBoxAfter.Multiline = true;
            this.textBoxAfter.Name = "textBoxAfter";
            this.textBoxAfter.Size = new System.Drawing.Size(398, 80);
            this.textBoxAfter.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 479);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(410, 90);
            this.textBoxOutput.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(77, 332);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(140, 30);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Зашифровать";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // CancelBut
            // 
            this.CancelBut.Enabled = false;
            this.CancelBut.Location = new System.Drawing.Point(223, 332);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(139, 30);
            this.CancelBut.TabIndex = 6;
            this.CancelBut.Text = "Прервать выполнение";
            this.CancelBut.UseVisualStyleBackColor = true;
            // 
            // OpenDocButton
            // 
            this.OpenDocButton.Location = new System.Drawing.Point(278, 18);
            this.OpenDocButton.Name = "OpenDocButton";
            this.OpenDocButton.Size = new System.Drawing.Size(144, 40);
            this.OpenDocButton.TabIndex = 7;
            this.OpenDocButton.Text = "Открыть описание алгоритма pdf";
            this.OpenDocButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 582);
            this.Controls.Add(this.OpenDocButton);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.groupBoxAfter);
            this.Controls.Add(this.groupBoxBefore);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "RSA Encryptor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyLenght)).EndInit();
            this.groupBoxBefore.ResumeLayout(false);
            this.groupBoxBefore.PerformLayout();
            this.groupBoxAfter.ResumeLayout(false);
            this.groupBoxAfter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label label_p;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Button GeneratePQbutton;
        private System.Windows.Forms.Button GenerateKeyButton;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.GroupBox groupBoxBefore;
        private System.Windows.Forms.TextBox textBoxBefore;
        private System.Windows.Forms.GroupBox groupBoxAfter;
        private System.Windows.Forms.TextBox textBoxAfter;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Button OpenDocButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numKeyLenght;
    }
}

