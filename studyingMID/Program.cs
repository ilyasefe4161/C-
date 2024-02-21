using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyingMID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();

            Console.WriteLine("String: "+dt.ToString());
            Console.WriteLine("Normal: "+dt);

            DateTime dt1 = new DateTime(2019, 12, 31, 5, 10, 20);
            Console.WriteLine(dt1);

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("NOW: "+currentDateTime.ToString());

            DateTime todaysDate = DateTime.Today;
            Console.WriteLine("TODAY: "+todaysDate.ToString());

            int daysInSeptember =DateTime.DaysInMonth(2001, 10);
            Console.WriteLine(daysInSeptember);

            Console.WriteLine("what is today(day of week): "+todaysDate.DayOfWeek);

            Console.WriteLine("Day of year: " + todaysDate.DayOfYear);

            Console.WriteLine("hour: " + currentDateTime.Hour);

            Console.WriteLine("month: " + currentDateTime.Month);

            Console.WriteLine("year: " + currentDateTime.Year);

            DateTime currentDateTimeUTC =DateTime.UtcNow;
            Console.WriteLine(currentDateTimeUTC.ToString());

            DateTime maxDateTimeValue =DateTime.MaxValue;
            Console.WriteLine(maxDateTimeValue);

            DateTime minDateTimeValue =DateTime.MinValue;
            Console.WriteLine(minDateTimeValue);



            Console.ReadKey();
        }
    }
}
