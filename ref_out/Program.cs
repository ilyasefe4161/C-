using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out
{
    internal class Program
    {
        public void getValues(ref int x, ref int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Program n = new Program();
            /* local variable definition */
            int a=0, b=0;
            /* calling a function to get the values */
            n.getValues(ref a, ref b);
            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.ReadLine();

            // ref kullanırsam ilk değerleriini vermem lazım!!!
        }
    }
}
