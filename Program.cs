namespace homeWork_1c_
{
    internal class Program
    {
        static void Main(string[] args)
        {//Задача 1. Квадраты в прямоугольнике + площадь остатка.
            Console.WriteLine("Задача 1.");
            Console.WriteLine("Введите стороны прямоугольника и сторону квадрата -> ");
            int a1, b1,c1;
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            c1 = Convert.ToInt32(Console.ReadLine());
             if (a1 >= c1)
            {
                int shotA = a1/c1;
                int longB = b1/c1;
                Console.WriteLine("В прямоугольнике поместится -> "+(shotA+longB)+" квадратов ");
              Console.WriteLine("Площадь остатка = "+((a1*b1)-((shotA*longB))*c1*c1));
                Console.WriteLine("\n\n");
            }
             else
            {
                Console.WriteLine("Введите корректное значение стороны квадрата!\n\n");
            }

            //Задача 2.
            Console.WriteLine("Задача 2.");
            double invest = 10000; //начальный вклад
            double finite = 11000;
            double k=1;
            Console.WriteLine("Начальный вклад -> " + invest + "грн");
            Console.WriteLine("Введите процент по вкладу от 0 до 25 -> ");
            double p = Convert.ToInt32(Console.ReadLine());
            if (p > 0 && p < 25)
            {
                while (invest < finite)
                {
                    invest += invest * p / 100;
                    k++;
                }
                Console.WriteLine($"{k} месяцев пройдет и капнет столько денюжек{invest}\n\n");
            }
           
            else
            {
                Console.WriteLine("Incorrect input!\n\n");
            }
            //Задача 3.
            Console.WriteLine("Задача 3.\nВведите два целых положительных числа -> ");
            int a3 = Convert.ToInt32(Console.ReadLine());
            int b3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            int tmp;
            if(a3 >= b3)
            {
                tmp = a3;
                a3 = b3;
                b3 = tmp;
            }
            for(int i = a3;i < b3;i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("\n");
            }
            

            //Задача 4.
            Console.WriteLine("Задача 4.\n Введите число ->");
            int N;
            int revN = 0;
            int remainder;
            N = Convert.ToInt32(Console.ReadLine());
            while (N != 0)
            {
                remainder = N%10;
                revN = revN*10+ remainder;
                N /= 10;
            }
            Console.WriteLine($"Число ноаборот ->{revN}");
            Console.ReadLine();
        }
    }
}
