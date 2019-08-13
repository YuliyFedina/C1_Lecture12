using System;
using System.Linq;

namespace Ex1
{
    public static class MasExtension
    {
        public static void OutputMas(this int[] mas)
        {
            foreach (var item in mas) Console.WriteLine(item);
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
            for (var i = 0; i < array.Length; i++) array[i] = rnd.Next(10);
            Console.WriteLine("Созданный массив:");
            array.OutputMas();

            Console.WriteLine();

            var filteredArray = array.Where(x => x > 5 || x % 2 == 0)
                .OrderByDescending(x => x);

            foreach (var item in filteredArray) Console.WriteLine(item);
        }
    }
}