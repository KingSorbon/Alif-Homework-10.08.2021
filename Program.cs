using System;

namespace Alif_Homework_10._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //homework 10.08.2021
            //Задания 2
            System.Console.Write("Введите сумму покупки: ");
            var X = decimal.TryParse(Console.ReadLine(), out var x);

            if (!X)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
            else if (x < 0)
            {
                System.Console.WriteLine("Сумма покупки не может быть меньше 0");
            }
            else if (x < 500)
            {
                System.Console.WriteLine($"Сумма к оплате: {x} самон");
            }
            else if (x > 1000)
            {
                var v = x / 100 * 5;
                var y = x - v;
                System.Console.WriteLine($"Ваша скидка 5% составляет: {v} самон");
                System.Console.WriteLine($"Сумма к оплате: {y} самон");
            }
            else if (x > 500)
            {
                var v = x / 100 * 3;
                var y = x - v;
                System.Console.WriteLine($"Ваша скидка 3% составляет: {v} самон");
                System.Console.WriteLine($"Сумма к оплате: {y} самон");
            }
            

            // задания 3
            int a = 1, b = 2, c = 3, d = 4;
            
            if (a > b && b > c && c > d ) 
            {
                Console.WriteLine($"{Math.Min(a, Math.Min(b, Math.Min(c, d)))}");
            }
            else if (a == b && b == c && c == d) {
                Console.WriteLine($"{ a * b * c * d}");              
            }          
            else  {
                Console.WriteLine("Числа расположены по возрастанию");
            }

            //задания 4
            int z = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int max = Math.Max(z, Math.Max(p, v));
            int min = Math.Min(z, Math.Min(p, v));
            int mid = z + p + v - max - min;
            Console.WriteLine($"Your max is:{max}, your min is:{min}, your mid is:{mid}");
        }
    }
}
