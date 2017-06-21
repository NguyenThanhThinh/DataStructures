using System;
using System.Collections.Generic;
using System.Linq;

namespace CountChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             EX: input:NguyenThanhThinh
                 ouput:n-->4
                       g-->1
                       u-->1
                       y-->1
                       e-->n
                       t-->2
                       h-->4
                       a-->1
                       i-->1 
             */
            Console.Write("input :\n ");
            string strString = Console.ReadLine().ToLower();
            strString.ToCharArray();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (var chars in strString)
            {
                if (!charCount.ContainsKey(chars))
                {
                    charCount.Add(chars, 0);
                }
                charCount[chars]++;
            }
            foreach (var number in charCount)
            {
                Console.WriteLine($"{number.Key} -- {number.Value}");
            }
            Console.ReadLine();

        }
    }
}
