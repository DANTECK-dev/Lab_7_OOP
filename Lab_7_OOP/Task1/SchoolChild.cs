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
                for (int i = 0; i < marks.Length; i++)
                {
                    if (value.Length <= i) marks[i] = null;
                    else marks[i] = value[i];
                }
            }
        }
        private int cur_class;
        public int Cur_Class
        {
            get
            {
                for(int i = 0; i < marks.Length; i++)
                    if (marks[i] == null)
                    {
                        cur_class = i+1;
                        return cur_class;
                    }
                return 1;
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
                + " | возвраст - " + this.Age
                + " | учебное учреждение - " + this.Educational_institution
                + " | направление школы - " + this.School_direction
                + " | оценки - " + marks
                + " | прогноз оценики - " + this.Next_Mark
                + " | текущий класс - " + this.Cur_Class;
        }

    }
}
