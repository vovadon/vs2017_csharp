using System;
using System.Collections.Generic;
using System.Threading;
using System.Numerics;

namespace RsaEncryptor
{
    // Класс для доступа к закрытым переменным
    // Доступен только в этой сборке
    internal static class Info
    {
        public static string P;
        public static string Q;
        public static string N;
        public static string D;
        public static string E;
    }

    public class MyRSA
    {
        private BigInteger p, q, n, phi, d, e;

        public Action<string> print { set; get; } // Делегат для отображения сообщений

        public void Create()
        {
            if (p == 0 || q == 0) // Проверка являются ли числа простыми
            {
                throw new Exception("p or q are zero");
            }

            n = p * q;
            print($"Вычисляем произведение N = p*q = {p}*{q} = {n}");
            Info.N = n.ToString(); // Записываем произведение простых чисел

            phi = (p - 1) * (q - 1);
            print($"Вычисляем функцию Эйлера phi(N) = (p - 1) * (q - 1) = {phi}");

            e = Calculate_e(phi);
            print($"Выбираем открытую экспоненту e = {e}");
            Info.E = e.ToString();

            BigInteger x, y;
            gcd(e, phi, out x, out y);
            d = (x % phi + phi) % phi;
            print($"Вычисляем секретную экспоненту e * d = 1 (mod phi(N)) или e * d + phi(N) * y = 1;\n{e} * d = 1 (mod {phi}), d = {d}");
            Info.D = d.ToString();

            print($"Открытый ключ {{e, N}} = {{{e},{n}}}");
            print($"Закрытый ключ {{d, N}} = {{{d},{n}}}");
            print("===Генерация ключей завершена===");
        }

        public string Encrypt(string str, CancellationToken token)
        {
            string result = "";

            print("===Процесс шифрования начат===");
            for (int i = 0; i < str.Length; i++)
            {
                token.ThrowIfCancellationRequested(); // Бросить исключение если была запрошена отмена

                BigInteger res;
                BigInteger Symbol = new BigInteger(Convert.ToUInt16(str[i])); // Инициализация объекта индексом символа

                res = PowerMod(Symbol, e, n);

                result += res.ToString() + " ";
            }
            print("===Процесс шифрования завершен===");
            return result;
        }

        public string Decrypt(string str, CancellationToken token)
        {
            string[] substrings = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            BigInteger a; // Хранит закодированный символ
            BigInteger res; // Расшифрованный символ

            print("===Процесс расшифрования начат===");

            foreach (string s in substrings)
            {
                token.ThrowIfCancellationRequested(); // Бросить исключение если была запрошена отмена 
                //if (s == "") break;

                a = BigInteger.Parse(s.ToString());

                res = PowerMod(a, d, n);

                result += Convert.ToChar((Int32)res);
            }

            print("===Процесс расшифрования завершен===");
            return result;
        }

        public void GenerateSimpleNum(int BitLenght) // BitLenght - длина простого числа, количество бит
        {
            SimpleNumber first = new SimpleNumber(BitLenght / 2);
            SimpleNumber second = new SimpleNumber(BitLenght / 2);

            this.p = first.GetSimpleNumber;
            this.q = second.GetSimpleNumber;

            Info.P = this.p.ToString();
            Info.Q = this.q.ToString();
        }

        // Возводит в степень по модулю
        private BigInteger PowerMod(BigInteger num, BigInteger exponent, BigInteger divisor)
        {
            BigInteger result = new BigInteger(1);

            // Понижение степени
            while (exponent > 2)
            {
                if (exponent % 2 == 0)
                {
                    num = BigInteger.Pow(num, 2) % divisor;
                    exponent = exponent / 2;
                }
                else
                {
                    result = (result * num) % divisor;
                    exponent--;
                }
            }
            num = BigInteger.Pow(num, (Int32)exponent) % divisor;
            result = (result * num) % divisor;

            return result;
        }

        private bool isNumberSimple(BigInteger num)
        {
            if (num < 2) return false;
            for (long i = 2; i < num; i++)
                if (num % i == 0) return false;
            return true;
        }

        private BigInteger Calculate_e(BigInteger phi)
        {
            BigInteger e = new BigInteger(2);

            while (phi % e == 0)
                e++;

            return e;
        }

        private long FindGCDEuclid(BigInteger a, BigInteger b) // Алгоритм Евклида для нахождения НОД
        {
            if (a == 0) return (Int32)b;
            while (b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return (Int32)a;
        }

        // Расширенный алгоритм Евклида для решения ур-я a*x+b*y=gcd(a,b)
        private long gcd(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y) 
        {
            if (a == 0)
            {
                x = 0; y = 1;
                return (long)b;
            }
            BigInteger x1, y1;
            BigInteger d = gcd(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return (long)d; // Возвращает НОД a и b
        }
    }
}
