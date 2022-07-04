// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double radius = Double.Parse(input);
            double area = Math.PI * (radius * radius);
            Console.WriteLine(area);
        }
    }
}