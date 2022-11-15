using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public class SchoolChild : Learner
    {
        private int?[] marks = new int?[11];
        public int?[] Marks
        {
            get => marks;
            set
            {
                int j = 0;
                for (int i = 0; i < marks.Length; i++)
                {
                    if (value.Length <= i) marks[j] = null;
                    else if (value[i] < 6 && value[i] > 0) { marks[j] = value[i]; j++; }
                    else continue;
                }
            }
        }
        private int cur_class;
        public int Cur_Class
        {
            get
            {
                for(int i = 0; i < marks.Length; i++)
                    if (marks[i] != null)
                        cur_class = i+1;
                return ++cur_class;
            }
        }
        private int next_mark;
        public int Next_Mark
        {
            get
            {
                int summ = 0;
                int count = 0;
                for (int i = 0; i < marks.Length; i++)
                {
                    if (marks[i] == null) break;
                    summ += (int)marks[i];
                    count = i+1;
                }
                return (int)summ / count; ;
            }
        }
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
            string marks = "";
            for (int i = 0; i < this.Marks.Length; i++)
                marks += this.Marks[i] + " ";
            return "Школьник: Имя - " + this.Name
                + "\n возвраст - " + this.Age
                + "\n учебное учреждение - " + this.Educational_institution
                + "\n направление школы - " + this.School_direction
                + "\n оценки - " + marks
                + "\n прогноз оценики - " + this.Next_Mark
                + "\n текущий класс - " + this.Cur_Class + "\n";
        }

    }
}
