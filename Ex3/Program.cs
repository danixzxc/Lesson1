using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y1");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите x2");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y2");
            int y2 = int.Parse(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2)
                + Math.Pow(y2 - y1, 2));

            Console.WriteLine("{0:f}", r);
        }
    }
}
