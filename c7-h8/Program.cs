using System;

namespace c7_h8
{
    internal class Program
    {
        double getAverage(int[] a, int length)
        {
            double sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += a[i];
            }
            return sum / length;
        }

        static void Main(string[] args)
        {
            int[] a = new int[10];
            int temp;
            Program app = new Program();

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter {0}. Number for Array: ", i + 1);
                temp = Convert.ToInt32(Console.ReadLine());
                a[i] = temp * temp;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}. index = {1} ", i, a[i]);
            }

            double avg = app.getAverage(a, a.Length);

            Console.WriteLine("Result is: " + avg);
            Console.ReadLine();

        }
    }
}
