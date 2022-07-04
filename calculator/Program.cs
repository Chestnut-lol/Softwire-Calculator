// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an operator: ");
            string op = Console.ReadLine();
            
            Console.WriteLine("Please enter a number: ");
            string input1 = Console.ReadLine();
            double num1 = Double.Parse(input1);
            Console.WriteLine("Please enter another number: ");
            string input2 = Console.ReadLine();
            double num2 = Double.Parse(input2);
            double ans = 0;
            switch (op)
            {
                case "+":
                    ans = num1 + num2;
                    break;
                case "-":
                    ans = num1 - num2; 
                    break;
                case "*":
                    ans = num1 * num2;
                    break;
                case "/":
                    ans = num1 / num2;
                    break;
            }
            Console.WriteLine(ans);
        }
    }
}