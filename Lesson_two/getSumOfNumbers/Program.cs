using System;


namespace getSumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Савенко Вадим
            //найти кол-во цифр в числе
            Console.WriteLine("Введите целое число!");
            Console.WriteLine("Кол-во цифр в числе: " + CalculateNumeralInNumber(Convert.ToInt32(Console.ReadLine())));
        }

        static int CalculateNumeralInNumber(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return CalculateNumeralInNumber(number / 10) +1;
            }
        }
    }
}
