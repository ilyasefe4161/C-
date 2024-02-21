using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.honk();
            Console.WriteLine(mycar.brand+" "+mycar.modelName);
            Console.ReadLine();
        }
    }
}
