using System;
using System.Linq;

namespace Ex1
{
    public static class MasExtension
    {
        public static void WriteToConsole<T>(this T[] array)
        {
            if (array.Length != 0)
            {
                foreach (var item in array) Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("Коллекция не содержит элементов");
            }
        }
    }

    internal class Program
    {
        private static void Main()
        {
            //Создать массив из 10 чисел.
            //Вывести на экран с помощью LINQ только четные или те, что больше 5.
            //Отсортировать по убыванию.

            var array = new int[10];
            var rnd = new Random();
            for (var i = 0; i < array.Length; i++) array[i] = rnd.Next(100);
            Console.WriteLine("Созданный массив:");
            array.WriteToConsole();

            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            array.Where(x => x > 5 || x % 2 == 0).OrderByDescending(x => x).ToArray().WriteToConsole();
        }
    }
}