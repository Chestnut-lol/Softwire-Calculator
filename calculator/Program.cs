// See https://aka.ms/new-console-template for more information

using System.IO.Compression;
using Calculator;
using Microsoft.VisualBasic.CompilerServices;

namespace Calculator
{
    class Utilities
    {
        public static int GetIntInput(string msg)
        {
            Console.Write(msg);
            string ans = Console.ReadLine();
            int answer;
            if (int.TryParse(ans, out answer))
            {
            }
            else
            {
                Console.WriteLine("Invalid answer! Try again.");
                answer = Utilities.GetIntInput(msg);
            }

            return answer;
        }
    }

    class NumCalc
    {
        static string GetOperator()
        {
            string[] ops = { "+", "*" };
            Console.Write("Which operator would you like to use? (Only support +, *)");
            string op = Console.ReadLine();
            if (ops.Contains(op))
            {
                return op;
            }

            return GetOperator();
        }

        private static List<int> GetNums(bool isDiv)
        {
            List<int> nums = new List<int>();
            while (true)
            {
                Console.Write("Enter number (Press enter to exit):");
                string ans = Console.ReadLine();
                if (ans == "")
                {
                    return nums;
                }

                if (int.TryParse(ans, out int num))
                {
                    if ((isDiv) && (num == 0) && (nums.Count > 0))
                    {
                        Console.WriteLine("Division by 0! Input ignored");
                    }

                    else {
                        nums.Add(num);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, input ignored.");
                }
            }
        }


        public static void DoOneNumCalc()
        {

            string op = GetOperator();
            Console.WriteLine($"How many numbers do you want to {op}? ");
            int cnt = int.Parse(Console.ReadLine());
            int[] nums = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                int num = Utilities.GetIntInput("Please Enter a number: ");
                nums[i] = num;
            }
            
            int ans = 0;
            foreach(int num in nums)
            {
                switch (op)
                {
                    case "+":
                        ans = num + ans;
                        continue;
                    case "-":
                        ans = num - ans; 
                        continue;
                    case "*":
                        ans = num * ans;
                        continue;
                    case "/":
                        ans = num / ans;
                        continue;
                }
            }
                
            Console.WriteLine(ans);

        }

        public static void DoNumCalcWithLst()
        {
            string op = GetOperator();

            List<int> nums = GetNums(op=="/");

            if (op == "+")
            {
                Console.WriteLine("Answer is: " + nums.Sum().ToString());
            }
            else if (op == "*")
            {
                int ans = nums.Aggregate(1, (a, b) => a * b, x => x);
                Console.WriteLine("Answer is: " + ans.ToString());
            }
            
        }
    }

    class DateCalc
    {
        static DateTime GetDate()
        {
            Console.WriteLine("Enter a date (DD/MM/YY): ");
            DateTime answer;
            string ans = Console.ReadLine();
            if (DateTime.TryParse(ans, out answer)){}
            else
            {
                Console.WriteLine("Invalid input! Try again.");
                answer = GetDate();
            }
            

            return answer;
        }

        

        public static void DoOneDateCalc()
        {

            DateTime date = GetDate();
            int NumOfDays = Utilities.GetIntInput("Enter number of days to add: ");
            Console.WriteLine($"The answer is: {date.AddDays(NumOfDays).ToShortDateString()}");
        }
        
    }
    public class NormalCalculator
    {
        
        static void PrintWelcomeMsg()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("================");
        }
        
        static int AskForCalcMode()
        {
            return Utilities.GetIntInput("Which calculator mode do you want? \n" +
                        "1) Numbers \n" +
                        "2) Dates \n");
        }
        private const int NUMCALC = 1;
        private const int DATECALC = 2;
        public static void Run()
        {
            PrintWelcomeMsg();
            while (true)
            {
                int calcMode = AskForCalcMode();
                if (calcMode == NUMCALC)
                {
                    NumCalc.DoOneNumCalc();
                }
                else
                {
                    DateCalc.DoOneDateCalc();
                }
            }
        }
    }

    public class CalculatorUsingCollections
    {
        static void PrintWelcomeMsg()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("================");
        }
        static int AskForCalcMode()
        {
            return Utilities.GetIntInput("Which calculator mode do you want? \n" +
                                         "1) Numbers \n" +
                                         "2) Dates \n");
        }
        private const int NUMCALC = 1;
        private const int DATECALC = 2;
        public static void Run()
        {
            PrintWelcomeMsg();
            while (true)
            {
                int calcMode = AskForCalcMode();
                if (calcMode == NUMCALC)
                {
                    NumCalc.DoNumCalcWithLst();
                }
                else
                {
                    DateCalc.DoOneDateCalc();
                }
            }
        }
        
    }

    public class Program
    {
        static void Main(string[] args)
        {
            CalculatorUsingCollections.Run();
        }
    }
}
    

    