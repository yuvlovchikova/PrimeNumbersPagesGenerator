using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MillersDeterminateAlgorythm
{
    public class Algorythm
    {
        /// <summary>
        /// Метод, проверяющий, является ли введенное число степенью какого-либо. Возвращает
        /// true, если является, и false в противоположном случае. Операционная сложность -
        /// O(Log2(n))
        /// </summary>
        /// <param name="n"></param> проверяемое число
        /// <returns></returns>
        public static bool IsPower(BigInteger n)
        {
            for (int i = 2; i < BigInteger.Log(n, 2); i++)
            {
                if (Math.Truncate(BigInteger.Log(n, i)) == BigInteger.Log(n, i)) return true;
            }
            return false;
        }

        /// <summary>
        /// Метод, проверяющий, является ли передаваемое нечетное число простым или составным
        /// детерминированным усовершенствованным алгоритмом Миллера. Возаращает true,
        /// если число простое, и false в противном случае
        /// </summary>
        /// <param name="n"></param> проверяемое число на простоту
        /// <returns></returns>
        public static bool Miller(BigInteger n)
        {
            // Массив первых 20-ти простых чисел. Согласно статье "Two kinds of strong
            // pseudoprimes up to 10^36" by Zhenxiang Zhang, если число, меньшее 10^36,
            // является псевдопростым по первым двадцати простым основаниям, то оно простое
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 };
            BigInteger t = n - 1;
            int s = 0;

            // цикл представления числа n-1=(2^s)*t
            while ((BigInteger.Remainder(t, 2)) == 0)
            {
                t = BigInteger.Divide(t, 2);
                s++;
            }

            // если число является точной степенью, то оно составное
            if (IsPower(n)) return false;
            for (int i = 0; i < primes.Length; i++)
            {
                BigInteger a = BigInteger.ModPow(primes[i], t, n);
                if (a == 1 || a == n - 1) continue;
                else
                {
                    int count = 0;
                    for (int q = 1; q < s; q++)
                    {
                        if (BigInteger.Remainder(BigInteger.Multiply(a, a), n) == n - 1) break;
                        count++;
                        a = BigInteger.Remainder(BigInteger.Multiply(a, a), n);
                    }
                    if (count == s - 1) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Метод, формирующий лист k простых чисел посредством проверки чисел справа и слева от
        /// N алгоритмом Миллера, до тех пор, пока не наберётся по k/2 чисел на каждом интервале
        /// </summary>
        /// <param name="N"></param> введённое пользователем число
        /// <param name="k"></param> количество чисел в листе
        /// <returns></returns>
        public static List<BigInteger> PrimeNumbersPage(BigInteger N, int k)
        {
            // поскольку заранее известно, что k выбирается равным 100, то если число N
            // мне превосходит k/2=50-ого простого числа, то список нужно формировать, начиная
            // с наименьшего простого числа. В таком случае медиана списка не будет являться ближайшим
            // простым числом к N
            const int p = 229;
            if (N < p)
            {
                List<BigInteger> list = new List<BigInteger> { 2, 3, 5, 7, 11, 13, 17, 19,
                    23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101,
                    103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179,
                    181, 191, 193, 197, 199,211,223,227,229,233,239,241,251,257,263,269,271,277,281,283,
                    293,307,311,313,317,331,337,347,349,353,359,367,373,379,383,389,397,401,409,419,421,
                    431,433,439,443,449,457,461,463,467,479,487,491,499,503,509,521,523,541};
                return list;
            }
            else
            {
                if (BigInteger.Remainder(N, 2) == 0) N = N + 1;
                List<BigInteger> list = new List<BigInteger>();
                BigInteger[] arr = new BigInteger[k];
                // поиск в правом интервале
                BigInteger current = N;
                for (int i = k / 2; i < k; i++)
                {
                    while (!Miller(current))
                    {
                        current += 2;
                    }
                    arr[i] = current;
                    current += 2;
                }

                // поиск в левом интервале
                current = N;
                for (int i = (k / 2) - 1; i >= 0; i--)
                {
                    while (!Miller(current))
                    {
                        current -= 2;
                    }
                    arr[i] = current;
                    current -= 2;
                }
                list = arr.ToList();
                return list;
            }

        }

        /// <summary>
        /// Метод, обновляющий список простых чисел для выведения в таблице при нажатии
        /// кнопки "вправо"
        /// </summary>
        /// <param name="length"></param> высота столбца
        /// <param name="list"></param> исходный список простых чисел из таблицы
        /// <returns></returns>
        public static List<BigInteger> PrimeNumbersRight(int length, List<BigInteger> list)
        {
            int size = list.Count();
            BigInteger current = list[size - 1] + 2;
            list.RemoveRange(0, length);
            for (int i = size - length - 1; i < size; i++)
            {
                while (!Miller(current))
                {
                    current += 2;
                }
                list.Add(current);
                current += 2;
            }
            return list;
        }

        /// <summary>
        /// Метод, обновляющий список простых чисел для выведения в таблице при нажатии
        /// кнопки "влево"
        /// </summary>
        /// <param name="length"></param> высота столбца
        /// <param name="list"></param> исходный список простых чисел из таблицы
        /// <returns></returns>
        public static List<BigInteger> PrimeNumbersLeft(int length, List<BigInteger> list)
        {
            int size = list.Count();

            // Заранее известно, что высота столбца равна 10, поэтому если наименьший элемент списка
            // лежит не позже второго столбца (то есть если не превосходит 11-е простое число),
            // то нужно формировать список, начиная с 2
            const int p = 127;
            if (list[0] < p)
            {
                List<BigInteger> listNew = new List<BigInteger> { 2, 3, 5, 7, 11, 13, 17, 19,
                    23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101,
                    103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179,
                    181, 191, 193, 197, 199,211,223,227,229,233,239,241,251,257,263,269,271,277,281,283,
                    293,307,311,313,317,331,337,347,349,353,359,367,373,379,383,389,397,401,409,419,421,
                    431,433,439,443,449,457,461,463,467,479,487,491,499,503,509,521,523,541};
                int index = -1;
                int sizeNew = listNew.Count();
                for (int i = 0; i < sizeNew; i++)
                {
                    index++;
                    if (listNew[i] == list[0])
                        break;
                }
                list.RemoveRange(size - length, length);
                if (index > 9)
                {
                    for (int i = index - 1; i > index - length - 1; i--)
                        list.Insert(0, listNew[i]);
                }
                else
                {
                    return listNew;
                }
                return list;
            }
            else
            {
                BigInteger current = list[0] - 2;
                list.RemoveRange(size - length, length);
                for (int i = size - length - 1; i < size; i++)
                {
                    while (!Miller(current))
                    {
                        current -= 2;
                    }
                    list.Insert(0, current);
                    current -= 2;
                }
                return list;
            }
        }
    }
}