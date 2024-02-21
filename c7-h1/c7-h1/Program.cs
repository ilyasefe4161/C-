namespace c7_h1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number: ");
            n = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("number is: " + n);
            if (n > 45)
                Console.WriteLine("n is greater than 45");
            else if(n < 45)
                Console.WriteLine("n is less than 45");
            else
                Console.WriteLine("n is equal 45");


        }
    }
}