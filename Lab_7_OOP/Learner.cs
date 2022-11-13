using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public abstract class Learner : Human
    {
        private string educational_institution;
        public string Educational_institution
        {
            get { return educational_institution; }
            set { if (value != null) educational_institution = value; }
        }
        public override int Age
        {
            get => base.Age;
            set { if (value < 40 && value > 6) base.Age = value; }
        }
        abstract public override string ToString();
    }
}
