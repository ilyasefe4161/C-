using System;
using System.Collections;

namespace Classes
{
    public class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }

        public Car(string color, string model)
        {
            Color = color;
            Model = model;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car("white", "opel");
            //Console.WriteLine(myObj.Color);
            //Console.WriteLine(myObj.Model);

            ArrayList arrayList = new ArrayList();
            arrayList.Add(myObj);
            arrayList.Add((Car)myObj);
            arrayList.Add(((Car)myObj).Model);
            arrayList.Add(myObj.Color);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
