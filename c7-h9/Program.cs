using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c7_h9
{
    internal class Program
    {
        int findMax(int[] a, int length)
        {
            int max=0,i=0;
            max = a[i];
            for (i=1; i<length; i++)
            {
                if (max < a[i])
                    max = a[i];
            }

            return max;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Program app = new Program();

            Console.WriteLine(app.findMax(a, a.Length));
            Console.ReadLine();
        }
    }
}
