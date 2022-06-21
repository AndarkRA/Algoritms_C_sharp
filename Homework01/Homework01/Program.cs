using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание к уроку 1");
            Console.WriteLine("======================");
            Console.WriteLine("1 -> Задача 1");
            Console.WriteLine("2 -> Задача 2");
            Console.WriteLine("3 -> Задача 3");
            Console.WriteLine("0 -> Заврешение работы приложения");
            Console.WriteLine("======================");
            Console.Write("Введите номер задачи ");
            int numberTask = int.Parse(Console.ReadLine());
            switch (numberTask)
            {
                case 1:
                    HW01Task01();
                    break;
                case 2:
                    HW01Task02();
                    break;
                case 3:
                    HW01Task03();
                    break;

                case 0:
                    Console.WriteLine("Завершение работы приложения ...");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Некорректный номер задачи, \nПовторите попытку ввода... ");
                    Console.ReadKey();
                    break;


            }
        }



        /// <summary>
        /// Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм
        /// проверки, простое число или нет.
        /// 1. Написать консольное приложение.
        /// 2. Алгоритм реализовать отдельно в функции согласно блок-схеме.
        /// 3. Написать проверочный код в main функции .
        /// 4. Код выложить на GitHub.
        /// </summary>
        public static void HW01Task01()
        {
            Console.WriteLine("Введите желаемое для проверки число");
            int number = int.Parse(Console.ReadLine());
            while (number < 1)
            {
                Console.WriteLine("Вы ввели число меньше одного,пожалуйста,повторите попытку.");
                number = int.Parse(Console.ReadLine());
            }

            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++; i++;
                }
                else
                    i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Ваше число простое.");
            }
            else
            {
                Console.WriteLine("Ваше число составное.");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Вычислите асимптотическую сложность функции из примера ниже
        /// </summary>
        public static void HW01Task02()
        {
            Console.WriteLine("асимптотическая сложность O(N^3)");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Метод вычисления числа Фибоначчи через цикл
        /// </summary>
        /// <param name="counter">порядковый номер элемента</param>
        /// <returns></returns>
        public static int GetFibonacciNumber(int counter)
        {
            int result;
            if (counter == 0)
            {
                result = 0;
            }
            else if (counter == 1)
            {
                result = 1;
            }
            else
            {
                int currentNumber = 1;
                int previousNumber = 0;
                int nextNumber = 0;

                for (int i = 2; i <= counter; i++)
                {
                    nextNumber = currentNumber + previousNumber;
                    previousNumber = currentNumber;
                    currentNumber = nextNumber;
                }
                result = nextNumber;
            }
            return result;

        }
        /// <summary>
        /// Метод вычисления числа Фибоначчи через рекурсию
        /// </summary>
        /// <param порядковый номер элемента="_counter"></param>
        /// <returns></returns>
        public static int GetFibonacciNumberRecursion(int counter)
        {

            int result;
            if (counter == 0)
            {
                result = 0;
            }
            else if (counter == 1)
            {
                result = 1;
            }
            else
            {
                result = GetFibonacciNumberRecursion(counter - 2) + GetFibonacciNumberRecursion(counter - 1);
            }
            return result;
        }

        /// <summary>
        /// Запись решения фибоначчи
        /// </summary>
        public static void HW01Task03()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Число Фибоначчи с индексом {i}. Подсчет через цикл. Число - {GetFibonacciNumber(i)}");
                Console.WriteLine($"Число Фибоначчи с индексом {i}. Подсчет через рекурсию. Число - {GetFibonacciNumberRecursion(i)}");
            }
            Console.ReadKey();
        }

    }
}
