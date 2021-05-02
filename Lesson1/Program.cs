using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string sname = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("имя - " + name + ", фамилия - "
                + sname + ", возраст - " + age + ", рост - "
                + h + ", вес - " + m);
        }
    }
}
