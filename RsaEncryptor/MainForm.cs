using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsaEncryptor
{
    public enum Mode // Перечисление режимов работы приложения
    {
        Encrypt,
        Decrypt
    }

    interface IMainForm
    {
        Mode SelectedMode { get; } // Свойство, кот. будет возвращать выбранный режим работы
        int GetKeyLenght { get; } // Свойство, кот. будет возвращать длину ключа

        void PrintMessage(string message); // Метод для отображения сообщений в textBoxOutput
        void SetPQnumbers(string _p, string _q); // Метод для записи простых чисел P и Q в textbox
        void SetNDEnumbers(string _n, string _d, string _e); // Метод будет записывать секретную и открытую экспоненту, а также произведение N и Q
        string GetTextBefore(); // Метод будет возвращать строку textBoxBefore (текст до шифрации/дешифрации)
        void SetTextAfter(string str); // Метод будет записывать строку в textBoxAfter (после шифрации/дешифрации)

        event EventHandler GeneratePQ;
        event EventHandler GenerateKey; // Сгенерировать ключ  
        event EventHandler Cancel_Button; // Кнопка отмены
        event Action<Button, Button> Start_Button; // Кнопка шифрации/дешифрации
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            radioEncrypt.CheckedChanged += RadioButtons_CheckedChanged;
            radioDecrypt.CheckedChanged += RadioButtons_CheckedChanged;

            GeneratePQbutton.Click += GeneratePQbutton_Click;
            GenerateKeyButton.Click += GenerateKeyButton_Click;
            StartButton.Click += StartButton_Click;
            CancelBut.Click += CancelBut_Click;
            
            OpenDocButton.Click += (o, args) => System.Diagnostics.Process.Start("algorithm.pdf");
            PrintMessage("===Запуск программы===");
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton obj = sender as RadioButton;
            if (Convert.ToInt16(obj.Tag) == 0) // Если был выбран режим шифрования
            {
                SelectedMode = Mode.Encrypt; // Устанавливаем режим шифрования

                groupBoxBefore.Text = "Шифрование";
                groupBoxAfter.Text = "Зашифрованный текст";
                StartButton.Text = "Зашифровать";
            }
            else if (Convert.ToInt16(obj.Tag) == 1) // Иначе
            {
                SelectedMode = Mode.Decrypt; // Устанавливаем режим расшифрования

                // Меняем надписи на кнопках
                groupBoxBefore.Text = "Зашифрованный текст";
                groupBoxAfter.Text = "Расшифрование";
                StartButton.Text = "Расшифровать";

                // Меняем сожержимое TextBox'ов
                string s = textBoxAfter.Text;
                textBoxAfter.Text = textBoxBefore.Text;
                textBoxBefore.Text = s;
            }
        }

        #region IMainForm
        public Mode SelectedMode { private set; get; } = Mode.Encrypt; // Изначально режим шифрования

        public int GetKeyLenght
        {
            get { return (int)numKeyLenght.Value; }
        }

        public void PrintMessage(string message)
        {
            Action action = () => textBoxOutput.AppendText(string.Format("{0} {1}\n", DateTime.Now.ToLongTimeString(), message));

            if (this.InvokeRequired)
                Invoke(action);
            else
                action();
        }

        public void SetPQnumbers(string _p, string _q)
        {
            textBox_p.Text = _p;
            textBox_q.Text = _q;
        }

        public void SetNDEnumbers(string _n, string _d, string _e)
        {
            textBox_N.Text = _n;
            textBox_d.Text = _d;
            textBox_e.Text = _e;
        }

        public string GetTextBefore()
        {
            return textBoxBefore.Text;
        }

        public void SetTextAfter(string str)
        {
            textBoxAfter.Text = str;
        }

        public event EventHandler GeneratePQ;
        public event EventHandler GenerateKey;       
        public event EventHandler Cancel_Button;
        public event Action<Button, Button> Start_Button;
        #endregion

        #region Проброс событий
        private void CancelBut_Click(object sender, EventArgs e)
        {
            if (Cancel_Button != null)
                Cancel_Button(this, EventArgs.Empty);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Start_Button != null)
                Start_Button(StartButton, CancelBut); 
            // Передаем ссылки на кнопки запуска и отмены, чтобы в обработчике события можно было задать свойство Enabled у кнопок
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            if (GenerateKey != null)
                GenerateKey(this, EventArgs.Empty);
        }

        private void GeneratePQbutton_Click(object sender, EventArgs e)
        {
            if (GeneratePQ != null)
                GeneratePQ(this, EventArgs.Empty);
        }
        #endregion
    }
}
