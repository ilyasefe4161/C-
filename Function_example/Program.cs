using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_example
{
    internal class Program
    {
        public int findMax(int n1, int n2)
        {
            int result;
            if(n1 > n2)
                result = n1;
            else
                result = n2;
            return result;
        }

        class Test
        {
            static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("enter two number");
            n1 = Convert.ToInt16(Console.ReadLine());
            n2 = Convert.ToInt16(Console.ReadLine());

            Program app = new Program();

            Console.WriteLine("Max number is: " + app.findMax(n1,n2));
            Console.ReadLine();
        }

        }
        
    }
}
