using Microsoft.VisualBasic;
using System;
using System.Net.Cache;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearOfBirth, monthOfBirth, dayOfBirth;
            
            DateTime Now = DateTime.Now;
            int ThisYear = Now.Year;            

            Console.WriteLine("Введите Ваше имя.");
            string name = Console.ReadLine();           
            
            Console.WriteLine("Теперь введите год Вашего рождения. Но только из нашей эры.");
            
            string enteredYear = Console.ReadLine();
            
            while (!int.TryParse(enteredYear, out yearOfBirth) || yearOfBirth >= ThisYear)
            {
                Console.WriteLine("С такими числами мне не приходилось работать. Попробуйте снова");
                enteredYear = Console.ReadLine();
            }
            
            Console.WriteLine("Теперь введите номер месяца от 1 до 12.");
            string enteredMonth = (Console.ReadLine());
            
            while (!int.TryParse(enteredMonth, out monthOfBirth) || monthOfBirth > 12)
            {
                Console.WriteLine("Пожалуйста, введите корректный номер месяца [1;12]");
                enteredMonth = (Console.ReadLine());
            }
            
            int lastMonthDay = DateTime.DaysInMonth(yearOfBirth, monthOfBirth);
            
            Console.WriteLine("Теперь введите номер дня, в который Вы родились");
            string enteredDay = Console.ReadLine();
            
            while (!int.TryParse(enteredDay, out dayOfBirth) || dayOfBirth > lastMonthDay)
            {
                Console.WriteLine("В уцказанном месяце нет дня с таким номером. Попробуйте снова.");
                enteredDay = Console.ReadLine();
            }
            
            DateTime Birhday = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

            int Age = ThisYear - Birhday.Year;
            
            if ( Now.Month <= Birhday.Month)
            {
                if (Now.Month == Birhday.Month)
                {
                    if (Now.Day < Birhday.Day)
                    { 
                        Age--;
                    }
                }
                else
                {
                    Age--;
                }
            }
            
            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + Age + " лет. Приятно познакомиться.");
        }

    }    
}
