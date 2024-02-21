using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_set_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            Console.WriteLine("enter your TC No: ");
            personel.tcno=Console.ReadLine();
            Console.WriteLine("TC No: "+personel.tcno);
            Console.ReadLine();
        }
    }
}
