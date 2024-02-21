using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_private_class_hmwrk
{
    internal class Student
    {
        private int studentNo;
        private string name;
        private string surname;
        private int midterm1;
        private int midterm2;
        private int final;
        private string schoolName;
        public Student(int studentNo, string name, string surname, int midterm1, int midterm2, int final, string schoolName)
        {
            this.studentNo = studentNo;
            this.name = name;
            this.surname = surname;
            this.midterm1 = midterm1;
            this.midterm2 = midterm2;
            this.final = final;
            this.schoolName = schoolName;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("studentNo: " + studentNo + " Name: " + name + " surname: " + surname);
        }

        public void showAveragePoint()
        {
            int average=(midterm1 + midterm2 + final)/3;
            Console.WriteLine("Average: " +average);
        }

        public string showSchoolName
        {
            get
            {
                return this.schoolName;
            }
        }
    }
}
