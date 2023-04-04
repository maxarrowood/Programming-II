using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang54bConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter #: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter #: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter #: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter #: ");
            int num4 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4;
            double avg = (double)sum / 4;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + Math.Round(avg, 2));

            Console.ReadKey();
        }
    }
}
