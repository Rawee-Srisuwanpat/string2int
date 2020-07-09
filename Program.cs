using System;
using System.Collections.Generic;

namespace string2int
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> output = new List<int>();
            Console.WriteLine("Please input string");
            string input = Console.ReadLine();

            foreach(char c in input)
            {
                if (Char.IsDigit(c))
                    output.Add(c);
            }

            if (output.Count == 0)
              Console.WriteLine("Not found numerical in input");
            else
            {
                string result = string.Empty;
                foreach(char i in output)
                    result += i ;
                Console.WriteLine("output :" + result);
            }
        }
    }
}
