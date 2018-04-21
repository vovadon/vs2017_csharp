using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace RsaEncryptor
{
    class MainPresenter
    {
        private readonly MyRSA _rsaObject;
        private readonly IMainForm _view; // Работаем с элементами формы через интерфейс
        private CancellationTokenSource tokenSourse;

        public MainPresenter(MyRSA rsaObj, IMainForm view)
        {
            _rsaObject = rsaObj;
            _view = view;

            _rsaObject.print = _view.PrintMessage;

            _view.GeneratePQ += _view_GeneratePQ;
            _view.GenerateKey += _view_GenerateKey;         
            _view.Cancel_Button += _view_Cancel_Button;
            _view.Start_Button += _view_Start_Button;
        }

        private void _view_Cancel_Button(object sender, EventArgs e)
        {
            if (tokenSourse != null)
                tokenSourse.Cancel();
        }

        private async void _view_Start_Button(Button start, Button cancel)
        {
            tokenSourse = new CancellationTokenSource();
            CancellationToken token = tokenSourse.Token;

            start.Enabled = false; // Запрещаем пользователю нажимать на кнопку запуска
            cancel.Enabled = true; // Разрешаем нажимать на кнопку отмены задачи

            Task<string> task = null;
            if (_view.SelectedMode == Mode.Encrypt) // Если режим работы шифрование
            {
                try
                {
                    // Запускаем метод шифрования в отдельной задачи
                    task = Task<string>.Factory.StartNew(() => _rsaObject.Encrypt(_view.GetTextBefore(), token), token);
                    string encryptedMessage = await task; // Ждем завершения задачи
                    // await разворачивает задачу в ее результат
                    _view.SetTextAfter(encryptedMessage); // Передаем зашифрованную строку
                }
                catch (OperationCanceledException ex) // Если задача была отменена
                {
                    string mes = (task.IsCanceled) ? "Процесс шифрования отменен" : ex.Message;
                    _view.PrintMessage(mes);
                }
            }
            else if (_view.SelectedMode == Mode.Decrypt)
            {
                try
                {
                    task = Task<string>.Factory.StartNew(() => _rsaObject.Decrypt(_view.GetTextBefore(), token), token);
                    string decryptedMessage = await task;
                    _view.SetTextAfter(decryptedMessage);
                }
                catch (OperationCanceledException ex)
                {
                    string mes = (task.IsCanceled) ? "Процесс расшифрования отменен" : ex.Message;
                    _view.PrintMessage(mes);
                }
            }
            start.Enabled = true;
            cancel.Enabled = false;
        }

        private async void _view_GenerateKey(object sender, EventArgs e)
        {
            try
            {
                Task create_key = Task.Factory.StartNew(() => _rsaObject.Create()); // Создаем и запускаем задачу
                await create_key; // Ждем завершения задачи
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _view.SetNDEnumbers(Info.N, Info.D, Info.E); // Устанавливаем значение переменных в textbox
        }

        private void _view_GeneratePQ(object sender, EventArgs e)
        {
            _rsaObject.GenerateSimpleNum(_view.GetKeyLenght);

            _view.SetPQnumbers(Info.P, Info.Q); // Устанавливаем значение простых чисел в textbox
        }
    }
}
