using Microsoft.VisualBasic;
using System;
using System.Net.Cache;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Now = DateTime.Now;

            Console.WriteLine("Введите Ваше имя.");
            string name = Console.ReadLine();
            
            int ThisYear = Now.Year;
            
            Console.WriteLine("Теперь введите год Вашего рождения. Но только из нашей эры.");
            int byear = Convert.ToInt32(Console.ReadLine());
            
            while (byear < 1 || byear >= ThisYear)
            {
                Console.WriteLine("С такими числами мне не приходилось работать. Попробуйте снова");
                byear = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Теперь введите номер месяца от 1 до 12.");
            int bmonth = Convert.ToInt32(Console.ReadLine());
            
            while (bmonth < 1 || bmonth > 12)
            {
                Console.WriteLine("Пожалуйста, введите корректный номер месяца [1;12]");
                bmonth = Convert.ToInt32(Console.ReadLine());
            }
            
            int LD = DateTime.DaysInMonth(byear, bmonth);
            
            Console.WriteLine("Теперь введите номер дня, в который Вы родились");
            int bday = Convert.ToInt32(Console.ReadLine());
            
            while (bday < 1 || bday > LD)
            {
                Console.WriteLine("В уцказанном месяце нет дня с таким номером. Попробуйте снова.");
                bday = Convert.ToInt32(Console.ReadLine());
            }
            
            DateTime Birhday = new DateTime(byear, bmonth, bday);
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
