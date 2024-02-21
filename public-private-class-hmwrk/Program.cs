using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_private_class_hmwrk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("1:ShowStudentInfo\n2:showAveragePoint\n3:showSchoolName\n4:exit ");
            n=Convert.ToInt32(Console.ReadLine());
            Student student = new Student(2010213027,"ilyas efe","sarısüleyman",100,90,70,"KBU");
            switch (n)
            {
                case 1: student.ShowStudentInfo(); break;
                case 2: student.showAveragePoint(); break;
                case 3: Console.WriteLine(student.showSchoolName) ; break;
                case 4: return;
                    default:Console.WriteLine("enter 1 to 4");
                    break;
            }
            Console.ReadLine();
        }
    }
}
