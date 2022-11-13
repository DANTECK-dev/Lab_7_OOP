using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public abstract class Employee : Human
    {
        private string company;
        public string Company
        {
            get { return company; }
            set { if (value != null) company = value; }
        }
        public override int Age
        {
            get => base.Age;
            set { if (value > 18) base.Age = value; }
        }
        abstract public override string ToString();
    }
}
