using Laba2_task_2;

namespace Лаба_2_2
{
    

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyTime time = new MyTime(10, 46, 0);

                Console.WriteLine("Початковий час: " + time);

                Console.WriteLine("Секунди з початку доби: " + time.SecondsSinceMidnight());

                time.AddOneSecond();
                Console.WriteLine("Після додавання 1 секунди: " + time);

                time.AddOneHour();
                Console.WriteLine("Після додавання 1 години: " + time);

                MyTime anotherTime = new MyTime(10, 45, 0);
                int difference = time.Difference(anotherTime);
                Console.WriteLine("Різниця в секундах: " + difference);

                string lesson = time.WhatLesson();
                Console.WriteLine("Зараз: " + lesson);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
    
}
