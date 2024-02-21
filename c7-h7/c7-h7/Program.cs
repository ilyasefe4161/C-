namespace c7_h7
{
    internal class MyArray
    {
        double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;
            for (i = 0; i < size; i++)
            {
                sum+=arr[i];
            }
            avg = (double)sum/size;
            return avg;
        }
        static void Main(string[] args)
        {
            MyArray app = new MyArray();

            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            avg = app.getAverage(balance, 5);

            Console.WriteLine("average value is : "+avg);
        }
    }
}