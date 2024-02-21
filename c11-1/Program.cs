using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c11_1
{
    internal class Program
    {
        public void Topla_Carp_Out(int a, int b, out int add, out int mult)
        {
            add = a + b;
            mult = a * b;
        }

        public void Topla_Carp_Ref(int a, int b, ref int add, ref int mult)
        {
            add = a + b;
            mult = a * b;
        }
        static void Main(string[] args)
        {
            int n1=43, n2=65, add=0, mult=0;
            Program app = new Program();

            Console.WriteLine("number 1: " + n1 + ", number 2: " + n2 + ", sum of numbers: " + add + ", multiplication of numbers: " + mult);

            app.Topla_Carp_Out(n1, n2, out add, out mult);
            Console.WriteLine("number 1: " + n1 + ", number 2: " + n2 + ", sum of numbers: " + add + ", multiplication of numbers: " + mult);

            app.Topla_Carp_Ref(n1, n2, ref add, ref mult);
            Console.WriteLine("number 1: " + n1 + ", number 2: " + n2 + ", sum of numbers: " + add + ", multiplication of numbers: " + mult);
            Console.ReadLine();
        }
    }
}
