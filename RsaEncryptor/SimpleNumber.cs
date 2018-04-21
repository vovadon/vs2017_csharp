using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Security.Cryptography;

namespace RsaEncryptor
{
    public class SimpleNumber
    {
        private int bitLenght; // Длина числа, количество бит
        private BigInteger _number; // Хранит проверяемое число
        private static readonly Random rnd = new Random();

        public BigInteger GetSimpleNumber
        {
            set { _number = value; }
            get { return _number; }
        }

        public SimpleNumber(BigInteger n)
        {
            _number = n;
        }

        public SimpleNumber(int _bitLenght)
        {
            bitLenght = _bitLenght;

            // Определяем диапазон чисел
            BigInteger min = BigInteger.Pow(2, bitLenght - 1); // Минимальное десятичное число, кот. занимает bitLenght бит
            BigInteger max = BigInteger.Pow(2, bitLenght);

            do
            {
                _number = Rand(min, max);
            } while (!MillerRabinTest(100));
        }

        // Полная проверка является ли число простым
        public bool FullCheckNumberSimple(BigInteger num)
        {
            if (num < 2) return false;
            for (long i = 2; i < num; i++)
                if (num % i == 0) return false;
            return true;
        }

        // Тест Миллера - Рабина позволяет определить, является ли данное число составным
        // https://ru.wikipedia.org/wiki/%D0%A2%D0%B5%D1%81%D1%82_%D0%9C%D0%B8%D0%BB%D0%BB%D0%B5%D1%80%D0%B0_%E2%80%94_%D0%A0%D0%B0%D0%B1%D0%B8%D0%BD%D0%B0
        public bool MillerRabinTest(int k) // k - количество раундов проверки на простоту числа
        {
            if (_number % 2 == 0) return false;

            // Необходимо представить n - 1 = 2^s * d, где d - нечётно
            BigInteger d = _number - 1;

            int s = 0;
            while (d % 2 == 0)
            {
                d = d / 2; // делим число на 2
                s++; // увеличивем степень двойки
            }

            for (int i = 0; i < k; i++)
            {
                // Выбираем случайное число в отрезке [2, n - 2]
                BigInteger a = Rand(2, _number - 2);

                // Вычисляется x = a^d mod n, где n - проверяемое число (_number)
                BigInteger x = PowerMod(a, d, _number);

                // Если x = 1 или x = n − 1, нужно выбрать другое число a
                if (x == 1 || x == _number - 1) continue; // Переходим на следующую итерацию

                for (int j = 1; j < s; j++)
                {
                    x = BigInteger.Pow(x, 2) % _number; // Вычисляется x = x^2 mod n

                    // Если x == 1 то число составное
                    if (x == 1) return false; 
                    if (x == _number - 1) break; // Если x = n − 1, то перейти на следующую итерацию внешнего цикла
                }

                if (x != _number - 1) return false;
            }
            return true;
        }
        
        // Возвращает случайное произвольно большое целове число в указанном диапазоне
        public BigInteger Rand(BigInteger minValue, BigInteger maxValue)
        {
            BigInteger result;
            // Объявляем и инициализируем массив байтов длинной максимального значения
            byte[] bytes = new byte[maxValue.ToByteArray().Length]; 

            do
            {
                rnd.NextBytes(bytes); // Заполнение массива байтов случайными числами
                result = new BigInteger(bytes);
            } while (result < minValue || result > maxValue); // Проверяем находится ли получанное число в диапазоне
            
            return result;
        }

        // Возводит в степень по модулю
        public static BigInteger PowerMod(BigInteger num, BigInteger exponent, BigInteger divisor)
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
    }
}
