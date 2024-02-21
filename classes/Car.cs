using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Car
    {
        private string color;
        private string model;
        public string Color {  get; set; }
        //public string model { get; set; }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Car(string color, string model)
        {
            Color = color;
            Model = model;
        }
        
    }
}
