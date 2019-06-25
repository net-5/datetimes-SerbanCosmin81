using System;

namespace DateTimeTryOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // DisplayDateTimeInfo();
            // AddYears();
            // HumanFriendly();//???
            // AddSeconds();
            // TimeToMiliSeconds();//hours and seconds
            // FutureDate();
            // FirstSecAndLastSecDay();
            // DateDiffInSec();
            // GetAge();
            // Past30NowFuture30();
            // DaysBetweenTwoDates();
            // YesterdayTodayTomorow();
            // FiveDaysFromToday();
            //GetFirstMondayOfGivenWeek();
            // DaysBetweenTwoDates2();
            SundaySelect();
        }
        //        # Datetime

        //1. Write a program to display the:

        //  ```
        //a) Current date and time //ok
        //b) Current year //ok
        //c) Month of year //ok
        //d) Week number of the year // ok
        //e) Weekday of the week//ok
        //f) Day of year //ok
        //g) Day of the month //ok
        //h) Day of week  // ok
        //j) if the current year is a leap year or not // ok

        static void DisplayDateTimeInfo()
        {
            DateTime myDate = DateTime.Now;

            Console.WriteLine($"This is the Current datetimeset {myDate}");
            Console.WriteLine($"This is the Current Year {myDate.Year}");
            Console.WriteLine($"This is the Current Month {myDate.Month}");
            Console.WriteLine($"we have {myDate.Year / 7} weeks this year");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                            DayOfWeek.Monday,
                            DayOfWeek.Tuesday,
                            DayOfWeek.Wednesday,
                            DayOfWeek.Thursday,
                            DayOfWeek.Friday,
                            DayOfWeek.Saturday,
                            DayOfWeek.Sunday);
            Console.WriteLine($"The current day of the week is {DateTime.Today.DayOfWeek}");
            Console.WriteLine($"This is the curret day of the week {myDate.DayOfWeek}");

            Console.WriteLine($"We are at the {myDate.DayOfYear} day of the Year {myDate.Year}");
            Console.WriteLine($"This is the current day name {myDate.DayOfWeek} and number {(int)myDate.DayOfWeek} of the week ");

            Console.WriteLine($"This is the Current day {myDate.Day} of the current month {myDate.ToString("MMMM")}");
            if (DateTime.IsLeapYear(myDate.Year))
            {
                Console.WriteLine("This is a leap Year !!!");
            }
            else
            {
                Console.WriteLine($"Sorry but this current year {myDate.Year} isn't a leap year !!!");
            }




        }

        //2. Write a program to add N year(s) to the current date and display the new date.

        public static void AddYears()
        {
            Console.Write("How many years u want to add: ");
            DateTime myDate = DateTime.Now;
            int addYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"Current year {myDate.Year} and theAddYear result {myDate.AddYears(addYear).Year}");
        }

        //3. Write a program to display the date and time in a human-friendly string.
        public static void HumanFriendly()
        {

            DateTime myDate = DateTime.Now;

            Console.WriteLine(myDate.ToLongDateString() + "\n" + myDate.ToLongTimeString());
        }

        // i think i didn't get the picture

        //4. Write a program to add 5 seconds to the current time and print it to the console.

        public static void AddSeconds()
        {
            Console.Write("How many seconds do u want to add: ");
            DateTime myTime = DateTime.Today;
            int addsSec = int.Parse(Console.ReadLine());
            Console.WriteLine($"Current time {myTime.ToLocalTime()} and the AddSec result {myTime.AddSeconds(addsSec).ToLocalTime()}");
        }

        //*5. Write a program to get current time in milliseconds.

        public static void TimeToMiliSeconds()
        {
            double myTimeHo = (new TimeSpan(DateTime.Now.Ticks) - new TimeSpan(DateTime.Today.Ticks)).TotalHours;
            Console.WriteLine(myTimeHo);

            double myTimeMIN = (new TimeSpan(DateTime.Now.Ticks) - new TimeSpan(DateTime.Today.Ticks)).TotalMinutes;
            Console.WriteLine(myTimeMIN);

            double myTimeMS = (new TimeSpan(DateTime.Now.Ticks) - new TimeSpan(DateTime.Today.Ticks)).TotalMilliseconds;
            Console.WriteLine(myTimeMS.ToString());
        }

        //6. Write a program that calculates the date six months from the current date.

        public static void FutureDate()
        {
            DateTime myFuture = DateTime.Now.AddMonths(6);
            Console.WriteLine($"The current date is {DateTime.Now} and the future date is {myFuture}");
        }

        //7. Write a program to get the first and last second of a day.

        public static void FirstSecAndLastSecDay()
        {
            DateTime today = DateTime.Today;
            double endToday = (today.AddHours(24) - today.AddSeconds(1)).TotalSeconds;

            Console.WriteLine($"The First second of any day is { today.AddSeconds(1).Second } and the last second of any day is { endToday }");
        }

        //*8. Write a program to calculate two date difference in seconds.

        public static void DateDiffInSec()
        {
            Console.WriteLine("Enter the first date: like this mm/dd/yyyy");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second date: like this mm/dd/yyyy");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(firstDate.ToShortDateString());
            Console.WriteLine(secondDate.ToShortDateString());
            double dateDiff = (firstDate - secondDate).TotalSeconds;
            Console.WriteLine($"The difference between the two date in second is {dateDiff}");

        }

        //9. Given a date of birth, calculate the age of a person.

        //``` 
        //        Input: 10, 09, 1989 
        //        Output: 29
        //```

        //Note: Requires parsing a string to make it a date. Get to me on slack to give you resources for this.

        public static void GetAge()
        {
            DateTime currDate = DateTime.Now;
            Console.WriteLine("Insert your birth date: mm/dd/yyyy");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            double age = currDate.Year - birthDate.Year;
            Console.WriteLine($"Your age is {age}");


        }

        //10. Write a program to get the dates 30 days before and after from the current date, and display it to the console

        public static void Past30NowFuture30()
        {
            DateTime myPresent = DateTime.Now;
            Console.WriteLine($"Past 30 days is {myPresent.AddDays(-30).ToShortDateString()} present date is {myPresent.ToShortDateString()} future 30 days is {myPresent.AddDays(30).ToShortDateString()}");
        }

        //11. Write a program to calculate a number of days between two dates.

        public static void DaysBetweenTwoDates()
        {
            Console.WriteLine("Insert first date: mm/dd/yyyy");
            DateTime myDate1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insert second date: mm/dd/yyyy");
            DateTime myDate2 = DateTime.Parse(Console.ReadLine());
            if (myDate1 < myDate2)
            {
                DateTime aux = myDate1;
                myDate1 = myDate2;
                myDate2 = aux;
            }
            double days = (myDate1 - myDate2).TotalDays;
            Console.WriteLine("The difference between the two dates is {0} days", days);
        }


        //12. Write a program to print yesterday, today, tomorrow.
        //``` 
        //      Yesterday :  2017-05-05 
        //      Today :  2017-05-06                  
        //      Tomorrow :  2017-05-0
        // ```

        public static void YesterdayTodayTomorow()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("Yesterday wass {0} \nToday is {1}\nTomorow will be {2}", today.AddDays(-1).ToShortDateString(), today.ToShortDateString(), today.AddDays(1).ToShortDateString());
        }


        //13. Write program to print next 5 days starting from today.

        public static void FiveDaysFromToday()
        {
            DateTime today = DateTime.Now;

            for (int i = 0; i < 5; i++)
            {
                DateTime daysSeq = today.AddDays(i);
                Console.WriteLine(daysSeq.ToShortDateString());

            }
        }


        //*14. Write a program to find the date of the first Monday of a given week

        //```
        //      Input  : 2015, 50
        //      Output : Mon Dec 14 00:00:00 2015      
        //```

        public static void GetFirstMondayOfGivenWeek()
        {
            Console.Write("Enter an year:");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter a week to serche the MONDAY:");
            int week = int.Parse(Console.ReadLine());
            DateTime firstDayOfYear = new DateTime(year, 1, 1);
            DateTime arriveToDate = firstDayOfYear.AddDays(week * 7);
            //Console.WriteLine("{0}\n{1}\n{2}\n{3}", firstDayOfYear, arriveToDate, arriveToDate.DayOfWeek, arriveToDate.AddDays(-1).DayOfWeek); // for verification
            while (arriveToDate.DayOfWeek != DayOfWeek.Monday)
            {
                TimeSpan oneDay = new TimeSpan(1, 0, 0, 0);
                arriveToDate = arriveToDate - oneDay;
            }
            Console.WriteLine("The First Monday of the inserted week {1} is on {0}", arriveToDate.ToShortDateString(), week);

        }

        //*15. Write a program to get days between two dates.
        //  ```
        //      Input :  
        //      2000,2,2
        //      2001,2,28
        //      Output : 366 days, 0:00:00
        //  ```

        public static void DaysBetweenTwoDates2()
        {
            Console.WriteLine("Insert first date: mm/dd/yyyy");
            DateTime myDate1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insert second date: mm/dd/yyyy");
            DateTime myDate2 = DateTime.Parse(Console.ReadLine());
            if (myDate1 < myDate2)
            {
                DateTime aux = myDate1;
                myDate1 = myDate2;
                myDate2 = aux;
            }
            double days = (myDate1 - myDate2).TotalDays;
            Console.WriteLine($"The difference between the two dates is {days} days");
        }



        //*16. Write a program to select all the Sundays of a specified year and display their dates

        //```
        //      Output:
        //      2020-01-05
        //      2020-01-12 
        //      2020-01-19
        //```

        public static void SundaySelect()
        {
            Console.WriteLine("Enter a date: mm/dd/yyyy ");
            DateTime myDate = DateTime.Parse(Console.ReadLine());
            int myYear = myDate.Year;
            DateTime firstDay = new DateTime(myYear, 1, 1);
            while (myYear == firstDay.Year)
            {
                if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("Sunday : {0}", firstDay.ToShortDateString());

                }
                firstDay = firstDay.AddDays(1);
            }


        }

    }
}