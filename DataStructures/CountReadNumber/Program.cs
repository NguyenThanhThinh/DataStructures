using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountReadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number n:");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("[{0}]", i);
                arr[i] = double.Parse(Console.ReadLine());
            }
            var previous = arr[0];
            var count = 1;
            if (arr.Count() > 0)
            {
                Array.Sort(arr);
                for (int i = 1; i < arr.Count(); i++)
                {

                    var currentNum = arr[i];
                    if (currentNum == previous)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{previous} - {count}");
                        count = 1;
                    }
                    previous = currentNum;
                }
                Console.WriteLine($"{previous} - {count}");
                Console.ReadLine();
            }
        }
    }
}
