namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myint = 100;
            var mydouble = 2.25;
            var mybool = true;

            Console.WriteLine(Convert.ToString(myint));
            Console.WriteLine(Convert.ToDouble(myint));
            Console.WriteLine(Convert.ToInt32(mydouble));
            Console.WriteLine(Convert.ToString(mybool));

            Console.WriteLine();

            Console.WriteLine("Type of myint is " + myint.GetType().ToString());
            Console.WriteLine("Type of mydouble is " + mydouble.GetType().ToString());
            Console.WriteLine("Type of mybool is " + mybool.GetType().ToString());
        }
    }
}