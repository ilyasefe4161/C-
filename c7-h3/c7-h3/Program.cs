namespace c7_h3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i += 2)
            {
                
                if (i == 60)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}