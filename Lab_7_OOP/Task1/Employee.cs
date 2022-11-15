using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    public abstract class Employee : Human
    {
        private int salary;
        public int Salary
        {
            get => salary;
            set { if (value > 0) salary = value; }
        }
        private int expYY;
        public int ExpYY
        {
            get => expYY;
            set { if (value > 0 && value > expYY) expYY = value; }
        }
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

        public void Print_Salary(Employee[] employees)
        {
            foreach (var employee in employees)
                Console.WriteLine
                    (
                        "Работник: Имя - " + this.Name
                        + " возвраст - " + this.Age
                        + " компания - " + this.Company
                        + " Стаж - " + this.ExpYY + " лет"
                        + " Зарплата - " + this.Calc_Salary()
                    );
        }
        abstract public int Calc_Salary();
        abstract public override string ToString();
    }
}
