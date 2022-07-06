// See https://aka.ms/new-console-template for more information

using Calculator;

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
        public static void DoOneNumCalc()
        {
            Console.WriteLine("Please enter an operator: ");
            string op = Console.ReadLine();
            Console.WriteLine($"How many numbers do you want to {op}?");
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
}
    public class Program
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
        static void Main(string[] args)
        {
            PrintWelcomeMsg();
            while (true)
            {
                int CalcMode = AskForCalcMode();
                if (CalcMode == NUMCALC)
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

    