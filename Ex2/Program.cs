using System;
using System.Linq;

namespace Ex2
{
    internal class Program
    {
        private static void Main()
        {
            //Создать коллекцию из 100 случайных дробей.
            //Выбрать все дроби, которые являются целым числом.
            //Вывести на консоль их как целые числа.

            var rnd = new Random();
            var n = 100;
            const int maxValue = 100;

            var fractions = new Fraction[n];

            for (var i = 0; i < n; i++)
            {
                fractions[i] = new Fraction(rnd.Next(-maxValue, maxValue), rnd.Next(1, maxValue));
                Console.WriteLine(fractions[i]);
            }

            Console.WriteLine();

            var integersFromFractions = fractions.Where(f => f.X % f.Y == 0).Select(f => f.X / f.Y);

            Console.WriteLine("Результат:");
            if (integersFromFractions.Any())
                foreach (var i in integersFromFractions)
                    Console.WriteLine(i);
            else
                Console.WriteLine("Нет целых чисел в последовательности дробей");
        }
    }
}