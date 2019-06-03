using System;

namespace Lesson_two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Савенко Вадим
            // Минимальное из трёх чисел

            Console.WriteLine("Введите 3 целых числа:");
            int[] Numbers = new int[3];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Минимальное число: "+GetMin(Numbers));
        }

        private static int GetMin(int[] Numbers)
        {
            int min = Numbers[0];
            for (int i = 1; i < Numbers.Length; i++)
            {
                min = min < Numbers[i] ? min:Numbers[i];
            }
            return min;
        }
    }
}
