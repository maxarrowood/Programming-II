using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strInterview8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.Write("Enter a character to search for: ");
            string cha = Console.ReadLine();

            int result = searchText(text, cha);
            Console.WriteLine("Does \"" + text + "\" contain \"" + cha + "\"?: " + result);
            Console.ReadLine();
        }

        static int searchText(string text, string cha) {
            int tLen = text.Length;
            int x = 0;

            for (int lcv = 0; lcv <= tLen; lcv++) {
                if (text.Substring(lcv) == cha) {
                    x++;
                }
            }
            return x;
        }
    }
}
