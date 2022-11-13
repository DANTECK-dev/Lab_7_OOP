using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public class Student : Learner
    {
        private string specialization;
        public string Specialization
        {
            get { return specialization; }
            set { if (value != null) specialization = value; }
        }
        public override int Age
        {
            get => base.Age;
            set { if (value < 16 && value > 30) base.Age = value; }
        }
        public override string ToString()
        {
            return "Студент: Имя - " + this.Name
                + " возвраст - " + this.Age
                + " учебное учреждение - " + this.Educational_institution
                + " специализация - " + this.Specialization;
        }
    }
}
