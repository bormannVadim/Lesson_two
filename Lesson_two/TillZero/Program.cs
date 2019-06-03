using System;

namespace TillZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            Console.WriteLine("Вводите целые числа, пока не введёте 0!");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 != 0 && number > 0)
                {
                    sum += number;
                }
       
            } while (number != 0);
            Console.WriteLine("Сумма нечетных положительных чисел: " + sum);
        }
    }
}
