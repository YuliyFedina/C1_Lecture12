using Ex1;
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
            const int countOfFractions = 100;
            const int maxValue = 100;

            var fractions = new Fraction[countOfFractions];

            for (var i = 0; i < countOfFractions; i++)
            {
                fractions[i] = new Fraction(rnd.Next(-maxValue, maxValue), rnd.Next(1, maxValue));
            }

            Console.WriteLine("Созданная коллекция случайных дробей");
            fractions.WriteToConsole();

            Console.WriteLine();
            Console.WriteLine("Целые числа из этой коллекции:");
            fractions.Where(x => x.X % x.Y == 0).Select(x => x.X / x.Y).OrderBy(x => x).ToArray().WriteToConsole();
        }
    }
}