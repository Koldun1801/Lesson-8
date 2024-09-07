using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo ski;

            Console.WriteLine("Нажмите на кнопку " +
                "\n\t1 — Задание 1; " +
                "\n\t2 — Задание 2;" +
                "\n\t3 — Задание 3;" +
                "\n\t4 — Задание 4");

            while (true)
            {
                ski = Console.ReadKey();


                if (ski.Key == ConsoleKey.D1 || ski.Key == ConsoleKey.NumPad1)
                {
                    Console.Write("\n");
                    Exercise_1();
                    break;
                }

                if (ski.Key == ConsoleKey.D2 || ski.Key == ConsoleKey.NumPad2)
                {
                    Console.Write("\n");
                    Exercise_2();
                    break;
                }
                if (ski.Key == ConsoleKey.D2 || ski.Key == ConsoleKey.NumPad3)
                {
                    Console.Write("\n");
                    Exercise_3();
                    break;
                }
                if (ski.Key == ConsoleKey.D4 || ski.Key == ConsoleKey.NumPad4)
                {
                    Console.Write("\n");
                    Exercise_4();
                    break;
                }
            }
            Console.ReadKey();

        }

        /// <summary>
        /// Задание 1. Работа с листом
        /// Что нужно сделать
        ///     Создайте лист целых чисел.
        ///     Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
        ///     Выведите коллекцию чисел на экран.
        ///     Удалите из листа числа, которые больше 25, но меньше 50. 
        ///     Снова выведите числа на экран.
        /// </summary>
        private static void Exercise_1()
        {
            List<int> list = CreateRandomList(0, 100, 100);
            WriteList(list);
            Console.Write("\n");
            WriteList(FiltrList(list,25,50));
        }

        /// <summary>
        /// Что нужно сделать
        ///     Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев.
        ///     В процессе ввода информация размещается в Dictionary, где ключом является номер телефона, а 
        ///     значением — ФИО владельца. Таким образом, у одного владельца может быть несколько номеров телефонов.
        ///     Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
        /// </summary>
        private static void Exercise_2()
        {
            Dictionary<int, string> phoneDictionary = new Dictionary<int, string>();

        }

        private static void Exercise_3()
        {
        }

        private static void Exercise_4()
        {
        }


        /// <summary>
        /// Создание списка псевдослучайных чисел
        /// </summary>
        /// <param name="minValue">минимальное значение</param>
        /// <param name="maxValue">максимальное значение</param>
        /// <param name="count">количество элемкнтов в списке</param>
        /// <returns></returns>
        private static List<int> CreateRandomList(int minValue, int maxValue, int count)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = count; i > 0; i--)
            {
                list.Add(random.Next(minValue, maxValue));
            }
            return list;
        }

        /// <summary>
        /// удаляет из списка элементы со значением между максимальным и минимальным значением
        /// </summary>
        /// <param name="list">фильтруемый список</param>
        /// <param name="minBoard">нижняя граница</param>
        /// <param name="maxBoard">верхняя граница</param>
        /// <returns></returns>
        private static List<int> FiltrList(List<int> list, int minBoard, int maxBoard)
        {
            for (int i = list.Count-1; i >= 0; i--)
            {
                if (list[i] <= maxBoard && list[i] >= minBoard)
                    list.RemoveAt(i);
            }
            return list;
        }

        /// <summary>
        /// Выводит список в консоль
        /// </summary>
        /// <param name="list"></param>
        private static void WriteList(List<int> list)
        {
            foreach (int a in list)
                Console.Write("{0} ", a);
        }
    }
}
