using System.Threading;
using System;

namespace secondP
{
    class Bread
    {
        public int counter;
    }
    static class Butter
    {
        public static int counter;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bread a = new Bread();
            a.counter = 5;
            Console.WriteLine("Bread: " + a.counter);
            Butter.counter = 7;
            Console.WriteLine("Butter: " + Butter.counter);
        }
    }
}