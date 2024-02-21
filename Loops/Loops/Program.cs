namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i < 20)
            {
                i++;
                if (i % 2 != 0)
                    continue;
                Console.WriteLine("i:" + i);
            }
                

        }
    }
}