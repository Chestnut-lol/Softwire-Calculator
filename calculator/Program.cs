// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static int GetIntInput(string msg)
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
                answer = GetIntInput(msg);
            }

            return answer;
        }
        static void PrintWelcomeMsg()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("================");
        }
        static void DoOneNumCalc()
        {
            Console.WriteLine("Please enter an operator: ");
            string op = Console.ReadLine();
            Console.WriteLine($"How many numbers do you want to {op}?");
            int cnt = int.Parse(Console.ReadLine());
            int[] nums = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                int num = GetIntInput("Please Enter a number: ");
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
        static void DoOneDateCalc()
        {

            DateTime date = GetDate();
            int NumOfDays = GetIntInput("Enter number of days to add: ");
            Console.WriteLine($"The answer is: {date.AddDays(NumOfDays).ToShortDateString()}");
        }

        static int AskForCalcMode()
        {
            return GetIntInput("Which calculator mode do you want? \n" +
                        "1) Numbers \n" +
                        "2) Dates \n");
        }
        private const int NumCalc = 1;
        private const int DateCalc = 2;
        static void Main(string[] args)
        {
            PrintWelcomeMsg();
            while (true)
            {
                int CalcMode = AskForCalcMode();
                if (CalcMode == NumCalc)
                {
                    DoOneNumCalc();
                }
                else
                {
                    DoOneDateCalc();
                }
            }
        }
    }
}