using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_
{
    internal class Program
    {
        public void swap(ref int n1, ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        public void swap1(out int n1)
        {
            int temp = 5;
            n1 = temp;
        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value (a): ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value (b): ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int n1 = 32;
            int n2 = 653;

            Console.WriteLine("Before swap, value of first number : {0}", n1);
            Console.WriteLine("Before swap, value of second number : {0}", n2);
            Program app = new Program();
            app.swap(ref n1, ref n2);
            Console.WriteLine("After swap, value of first number : {0}", n1);
            Console.WriteLine("After swap, value of second number : {0}", n2);

            Console.WriteLine();

            
            Console.WriteLine("Before method call, value of first number : {0}", n1);
            app.swap1(out n1);
            Console.WriteLine("After method call, value of first number : {0}", n1);

            Console.WriteLine();

            int a, b;

            app.getValues(out a, out b);
            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);




            Console.ReadLine();

        }
    }
}
