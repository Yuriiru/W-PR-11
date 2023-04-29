using System;

    internal class Program
    {
        delegate string WeekDaysDelegate();
        static void Main(string[] args)
        {
            string[] WeekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            int index = -1;

            WeekDaysDelegate weekDaysDelegate = () =>
            {
                index = (index + 1) % 7;
                return WeekDays[index];
            };

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(weekDaysDelegate());
            }

            Console.ReadLine();
        }
    }

