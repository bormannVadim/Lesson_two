using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {// Савенко Вадим

            /*
             * <=16 и менее	Выраженный дефицит массы тела
                16—18,5	Недостаточная (дефицит) масса тела
                18,5—24,99	Норма
                25—30	Избыточная масса тела (предожирение)
                30—35	Ожирение
                35—40	Ожирение резкое
                40 и более	Очень резкое ожирение
             * */
            Console.WriteLine("Введите массу тела в кг.");
            double Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой рост в см.");
            double Height = Convert.ToDouble(Console.ReadLine())/100;

            Calculate(Weight, Height);
        
        }

        static void Calculate(double weight, double height)
        {
            double coefficient = weight / Math.Pow(height, 2);
            if (coefficient <= 16)
                Console.WriteLine("У вас выраженный дефицит коллорий! Вам нужно срочно начать есть...");
            else if (coefficient > 16 && coefficient <= 18.5)
                Console.WriteLine("У вас дефицит коллорий! Вам нужно  начинать есть...");
            else if (coefficient > 18.5 && coefficient <= 25)
            {
                Console.WriteLine("У вас всё хорошо!");
                return ;
            }
            else if (coefficient > 25 && coefficient <= 30)
                Console.WriteLine("У вас избыточный вес! Пора бы задуматься о диете...");
            else if (coefficient > 30 && coefficient <= 35)
                Console.WriteLine("У вас первая стадия ожирения! Пора бы заняться спортом...");
            else if (coefficient > 35 && coefficient <= 40)
                Console.WriteLine("Вы близитесь к состоянию 'жирный'! Немедленно займитесь собой...");
            else
                Console.WriteLine("Вы жирный! Вам нужно срочно похудеть...");

            Fitness(weight, height);
        }

        static void Fitness(double weight, double height)
        {
           
            double UsualWeight = weight;
            double coefficient;
            do
            {
                coefficient = weight / Math.Pow(height, 2);
                if (coefficient <= 18.5)
                {
                    weight++;
                }
                else
                {

                    weight--;
               }
            }
            while (coefficient <= 18.5 || coefficient > 25);
      
            double result = UsualWeight-weight ;

            if (result < 0)// похудеть
            {
                Console.WriteLine("Вам нужно набрать: " + Math.Abs(result) + " кг.");
            }
            else // набрать
            {
                Console.WriteLine("Вам нужно сбросить: " + result + " кг.");
            }
        }
    }
}
