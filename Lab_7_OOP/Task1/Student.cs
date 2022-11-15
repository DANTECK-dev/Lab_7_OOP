using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public class Student : Learner
    {
        private int?[] marks = new int?[8];
        public int?[] Marks
        {
            get => marks;
            set
            {
                for(int i = 0; i < marks.Length; i++)
                {
                    if (value.Length <= i) marks[i] = null;
                    else marks[i] = value[i];
                }
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
        private int cur_semestr;
        public int Cur_Semestr
        {
            get
            {
                for (int i = 0; i < marks.Length; i++)
                    if (marks[i] == null)
                    {
                        if((i+1)%2 == 0)
                            cur_semestr = (i + 1) / 2;
                        else
                            cur_semestr = (i + 2) / 2;
                        return cur_semestr;
                    }
                return 1;
            }
        }
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
            string marks = "";
            for (int i = 0; i < this.Marks.Length; i++)
                marks += this.Marks[i] + " ";
            return "Студент: Имя - " + this.Name
                + " | возвраст - " + this.Age
                + " | учебное учреждение - " + this.Educational_institution
                + " | специализация - " + this.Specialization
                + " | оценки - " + marks
                + " | прогноз оценки - " + this.Next_Mark
                + " | текущий семестр - " + this.Cur_Semestr;
        }
    }
}
