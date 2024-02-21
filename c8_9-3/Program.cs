using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_9_3
{
    internal class Program
    {
        enum calisanlar
        {
            Idareci = 100,
            Ogretmen = 200,
            Memur = 300,
            Hizmetli = 400
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("1:idareci 2: öğretmen 3:memur 4: hizmetli");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine((int)calisanlar.Idareci + " TL");
                    break;
                case 2:
                    Console.WriteLine((int)calisanlar.Ogretmen + " TL");
                    break;
                case 3:
                    Console.WriteLine((int)calisanlar.Memur + " TL");
                    break;
                case 4:
                    Console.WriteLine((int)calisanlar.Hizmetli + " TL");
                    break;
                default:
                    Console.WriteLine("Please enter 1:idareci 2: öğretmen 3:memur 4: hizmetli");
                    break;
            }
            Console.ReadLine();
        }
    }
}
