using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_studying
{
    internal class Person
    {
        private string name; // field
        public string Name // property
        {
            get { return name; }
            set { name = value; }
        }
        //public string Name { get; set; }
    }
}
