using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public abstract class Human
    {
        private string name { get; set; }
        public string Name 
        {
            get { return name; } 
            set { if (value != null) name = value; }
        }
        private int age;

        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 120) age = value;
            }
        }
        abstract public override string ToString();
    }
}
