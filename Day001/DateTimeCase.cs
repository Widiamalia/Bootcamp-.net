using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day001
{
    internal class DateTimeCase
    {
        public static void DateTimeCases()
        {
            DateTime now = DateTime.Now;

            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;

            //only date
            DateTime onlyDate = now.Date;
            Console.WriteLine($"Only Date : {onlyDate}");

            //DayOfWeek
            DayOfWeek dayOfWeek = now.DayOfWeek;
            DayOfWeek kamis = DayOfWeek.Thursday;

            //addDays
            DateTime tomorrow = now.AddDays(2);

            //Selisih Hari
            TimeSpan dateDifference = tomorrow - now;
            int dayRemaining = dateDifference.Days;
            Console.WriteLine($"{now} {tomorrow},selisih : {dayRemaining}");

            //store spesific date
            DateTime birthday = new DateTime(1998, 10, 21);


        }
    }
}