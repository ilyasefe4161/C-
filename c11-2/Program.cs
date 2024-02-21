using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime nowdt = DateTime.Now;
            var list1 = new ArrayList()
            {
                "ilyas efe","sarisuleyman",new DateTime(2002,4,27)
            };

            foreach (var item in list1)
                Console.WriteLine(item);
            
            Console.WriteLine(nowdt);


            var yas = nowdt - (DateTime)list1[2];

            Console.WriteLine("Age: {0}", yas.TotalDays / 365);

            Console.ReadLine();
        }
    }
}
