using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Console.Write("Array: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Array.Sort(a);
            Console.WriteLine();
            Console.Write("Sorted Array:");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Array.Reverse(a);
            Console.WriteLine();
            Console.Write("Reverse Array: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
