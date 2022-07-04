// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an operator: ");
            string op = Console.ReadLine();
            Console.WriteLine($"How many numbers do you want to {op}?");
            int cnt = int.Parse(Console.ReadLine());
            int[] nums = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine("Please enter a number: ");
                string input = Console.ReadLine();
                int num = int.Parse(input);
                nums.Add(num);
            }
            
            int ans = 0;
            foreach(int num in nums)
            {
                Console.WriteLine(num);
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
}