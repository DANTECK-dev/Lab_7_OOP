using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public class SchoolChild : Learner
    {
        private string school_direction;
        public string School_direction
        {
            get { return school_direction; }
            set { if (value != null) school_direction = value; }
        }
        public override int Age
        {
            get => base.Age;
            set { if (value < 20 && value > 6) base.Age = value; }
        }
        public override string ToString()
        {
            return "Школьник: Имя - " + this.Name
                + " возвраст - " + this.Age
                + " учебное учреждение - " + this.Educational_institution
                + " направление школы - " + this.School_direction;
        }

    }
}
