// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static int GetIntInput(string msg)
        {
            Console.Write(msg);
            string ans = Console.ReadLine();
            return int.Parse(ans);
        }
        static void PrintWelcomeMsg()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("================");
        }
        static void PerformCalculation()
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

        static void Main(string[] args)
        {
            PrintWelcomeMsg();
            while (true)
            {
                PerformCalculation();
            }
        }
    }
}