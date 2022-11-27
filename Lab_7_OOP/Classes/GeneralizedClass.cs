using Lab_7_OOP.Classes;

namespace Lab_7_OOP.Classes
{
    public static class GeneralizedClass<T> where T : Learner
    {
        /*
         * Возврат элемент из массива данных (если индекс элемента неправильный, то вернуть null).
         * Вывести данные всех элементов массива (используйте метод Вывод).
         * Сделать Прогноз для каждого элемента массива.
         */

        public static Learner Get(List<Learner> learners, int index)
        {
            if (index < learners.Count)
                return learners[index];
            else
                return null;
        }
        public static void Print(List<Learner> learners)
        {
            learners.ForEach(x => Console.WriteLine(x.ToString()));
        }
        public static int Forecast(int?[] marks)
        {
            int summ = 0;
            int count = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == null) break;
                summ += (int)marks[i];
                count = i + 1;
            }
            return (int)summ / count;
        }
    }
}
