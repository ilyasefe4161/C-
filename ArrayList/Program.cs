using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add(1);
            list.Add("Bill");
            list.Add(" ");
            list.Add(true);
            list.Add(1.5);
            list.Add(null);

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ=new Queue();
            myQ.Enqueue("hello");
            myQ.Enqueue("world");


            list.AddRange(arr);
            list.AddRange(myQ);

            foreach (var val in list)
                Console.WriteLine(val);


        }
    }
}
