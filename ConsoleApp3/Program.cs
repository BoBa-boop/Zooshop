using System;

namespace ConsoleApp3
{
    class Зоомагазин
    {
        public string pet;
        public string sex;
        public string name;
        public int price;
        public int amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Зоомагазин p1 = new Зоомагазин();
            Console.WriteLine("Введите животное");
            p1.pet = Console.ReadLine();
            Console.WriteLine("Введите пол");
            p1.sex = Console.ReadLine();
            Console.WriteLine("Введите имя животного");
            p1.name = Console.ReadLine();
            Console.WriteLine("Введите цену");
            p1.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во животных");
            p1.amount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine(p1.pet + "\t" + p1.sex + "\t" + p1.name + "\t" + p1.price + "\t" + p1.amount);
            Console.ReadKey();
        }
    }
}
