using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcWithFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Num 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Num 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Choose an Options; Add, Sub, Mul, or Div: ");
            string op = Console.ReadLine();
            int result = 0;
            if (op == "add") result = add(n1, n2);
            else if (op == "sub") result = sub(n1, n2);
            else if (op == "mul") result = mul(n1, n2);
            else if (op == "div") result = div(n1, n2);
            Console.WriteLine("Result: " + result);

            wait();
        }

        // <access level> <stattic or not> <return type name(<args>) {}
        // In consle apps, we'll make all functions "static"
        // Not static in Forms apps; always "public" regardless

        public static void wait() {
            Console.ReadLine();
        }

        public static int add(int x, int y) {
            return x + y;
        }

        public static int sub(int x, int y)
        {
            return x - y;
        }

        public static int mul(int x, int y)
        {
            return x * y;
        }

        public static int div(int x, int y)
        {
            return x / y;
        }
    }
}
