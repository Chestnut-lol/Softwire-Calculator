// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            double num1 = Double.Parse(input1);
            string input2 = Console.ReadLine();
            double num2 = Double.Parse(input2);
            double ans = num1 + num2;
            Console.WriteLine(ans);
        }
    }
}