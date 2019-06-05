using System;


namespace Считаем_числа_от_1_до_1_000_000_000
{
    class Program
    {
        static void Main(string[] args)
        {
            // Савенко Вадим
            int number;
            do
            {
                Console.WriteLine("Введите число от 1 до 1 000 000 000");
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1 || number > 1000000000)
                    Console.WriteLine("Вы ввели не корректное число... Попробуйте ещё раз..\n");
            } while (!(number >= 1 && number <= 1000000000));

            DateTime start = DateTime.Now;

           
            int otvet = 0;
            for (int i = 1; i <= number; i++)// проходимся по всем числам
            {
                if (i % CountDigiSum(i) == 0)
                    otvet++;
            }
            Console.WriteLine("Кол-во хороших чисел в числе " + number + " равно " + otvet);

            DateTime end = DateTime.Now;
            Console.WriteLine("Время работы программы: " + (end - start));
        }

        static int CountDigiSum(int number)
        {
            // можно сделать рекурсией
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return CountDigiSum(number / 10) + number % 10;
            }
        }
    }
}
