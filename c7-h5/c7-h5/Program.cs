namespace c7_h5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 100)
            {

                if (i == 60)
                {
                    i += 2;
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                    i += 2;
                }
                
            }
        }
    }
}