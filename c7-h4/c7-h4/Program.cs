namespace c7_h4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i += 2)
            {
                if (i == 60)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}