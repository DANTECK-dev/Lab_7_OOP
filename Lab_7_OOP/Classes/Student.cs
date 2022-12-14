using Lab_7_OOP.Classes;

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
                next_mark = GeneralizedClass<SchoolChild>.Forecast(marks);
                return next_mark;
            }
        }
        private int cur_semestr;
        public int Cur_Semestr
        {
            get
            {
                for (int i = 0; i < marks.Length; i++)
                    if (marks[i] != null)
                    {
                        if((i+1)%2 == 0)
                            cur_semestr = (i) / 2;
                        else
                            cur_semestr = (i + 1) / 2;
                    }
                return ++cur_semestr;
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
                + "\n возвраст - " + this.Age
                + "\n учебное учреждение - " + this.Educational_institution
                + "\n специализация - " + this.Specialization
                + "\n оценки - " + marks
                + "\n прогноз оценки - " + this.Next_Mark
                + "\n текущий курс - " + this.Cur_Semestr + "\n";
        }
    }
}
