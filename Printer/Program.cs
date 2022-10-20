using System;

namespace Printer
{
    public class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine($"Value = {value}.");
            Console.WriteLine();
        }
    }

    public class Printer2 : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Value = {value}.");
            Console.WriteLine();
            Console.ResetColor();
        }
    }

    public class Printer3 : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Value = {value}.");
            Console.WriteLine();
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            string v1 = Console.ReadLine();

            Printer printer1 = new Printer();
            printer1.Print(v1);

            Console.Write("Enter a second value: ");
            string v2 = Console.ReadLine();

            Printer2 printer2 = new Printer2();
            printer2.Print(v2);

            Console.Write("Enter the third value: ");
            string v3 = Console.ReadLine();

            Printer3 printer3 = new Printer3();
            printer3.Print(v3);
        }
    }
}
