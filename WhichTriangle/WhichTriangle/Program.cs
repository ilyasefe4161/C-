namespace WhichTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3;

            Console.WriteLine("enter a number for a1");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number for a2");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number for a3");
            a3 = Convert.ToInt32(Console.ReadLine());

            if (a1 == a2 && a2 == a3 && a1 == a3)
            {
                Console.WriteLine("This is equilateral triangle (eşkenar)");
            }
            else if(a1 != a2 && a2 != a3 && a1 != a3)
            {
                Console.WriteLine("This is scalene triangle (çeşitkenar)");
            }
            else if(a1 == a2 && a2 != a3 && a1 != a3 || a1 != a2 && a1 == a3 && a2 != a3 || a1 != a2 && a1 != a3 && a2 == a3)
            {
                Console.WriteLine("This is isosceles triangle (ikizkenar)");
            }
        }
    }
}