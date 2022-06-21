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
            Console.WriteLine("0 -> Заврешение работы приложения");
            Console.WriteLine("======================");
            Console.Write("Введите номер задачи ");
            int numberTask = int.Parse(Console.ReadLine());
            switch (numberTask)
            {
                case 1:
                    HW01Task01();
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


    }
}
