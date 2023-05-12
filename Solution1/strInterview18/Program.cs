using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strInterview18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.Write("Enter a character to remove: ");
            string cha = Console.ReadLine();

            string result = searchText(text, cha);
            Console.WriteLine("The new string is: " + result);
            Console.ReadLine();
        }

        static string searchText(string text, string cha)
        {
            int tLen = text.Length;

            for (int lcv = 0; lcv <= tLen; lcv++)
            {
                if (text.Substring(lcv) == cha)
                {
                    text.Remove(lcv);
                }
            }
            return text;
        }
    }
}
