using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP
{
    static class Programm
    {
        static void Main(string[] _)
        {
            Task1();
            Task2();
            Task3();
        }
        private static void Task1()
        {
            List<Human> list = new List<Human>();
            list.Add(new Manager() { 
                Name = "Иванов Иван Иванович",
                Age = 45,
                Company = "ООО ААА ООО",
                Department = "Бухгалтерия"
            }) ;
            list.Add(new Contrator()
            {
                Name = "Иванов Иван Иванович",
                Age = 45,
                Company = "ООО ААА ООО",
                Tasks = "Учёт товара"
            });
            list.Add(new SchoolChild()
            {
                Name = "Иванов Иван Иванович",
                Age = 45,
                Educational_institution = "ООО ААА ООО",
                School_direction = "Математическая школа"
            });
            list.Add(new Student()
            {
                Name = "Иванов Иван Иванович",
                Age = 45,
                Educational_institution = "ООО ААА ООО",
                Specialization = "Адвокат"
            });
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i].ToString());
            Console.ReadKey();
            return;
        }   
        private static void Task2()
        {

            return;
        }
        private static void Task3()
        {

            return;
        }
    }
}
