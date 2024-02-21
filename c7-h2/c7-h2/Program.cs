namespace c7_h2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("enter a number for triangle");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number for triangle");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number for triangle");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2 && n2 == n3 && n1 == n3)
                Console.WriteLine("Equilateral triangle");
            else if (n1 != n2 && n2 != n3 && n1 != n3)
                Console.WriteLine("each edge is of different length");
            else
                Console.WriteLine("isosceles triangle");
        }
    }
}