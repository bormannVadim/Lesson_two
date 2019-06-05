using System;

namespace Задание_7_рекурсивный_метод
{
    class Program
    {
        static void Main(string[] args)
        {
            //Савенко Вадим
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());

            FromAtoB(a, b);
        }

        static void FromAtoB(int a, int b)
        {
            if (a >= b)
            {
                return;
            }
            else
            {
                    a++;
                    if (a == b)
                    return;
                    else
                    Console.WriteLine(a);
           
                FromAtoB(a, b);
            }
        }
    }
}
