using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Workdays
{
    static void Main()
    {
        Console.WriteLine("Today is {0} - {1}. ", DateTime.Now.Day, DateTime.Now);
        Console.WriteLine("Enter date limit: (Example: 2015/12/23)");
        string[] date = Console.ReadLine().Split('/');
        int year = int.Parse(date[0]);
        int month = int.Parse(date[1]);
        int day = int.Parse(date[2]);
        DateTime startday = DateTime.Today;
        DateTime endday = new DateTime(year, month, day);
        if (endday <= startday)
        {
            Console.WriteLine("Invalid date!");
            return;
        }
        //special days
        DateTime[] holidays = 
    {
        new DateTime(2013,09,23),
        new DateTime(2013,09,24),
        new DateTime(2013,09,25)
    };
        DateTime[] extraworkdays = 
    {
        new DateTime(2013,09,28),
        new DateTime(2013,09,29)
    };
        //main
        int workday = 0;
        bool isholiday = false;
        bool isextraworkday = false;
        for (; startday <= endday; )
        {
            //check holidays
            foreach (DateTime holiday in holidays)
            {
                if (holiday == startday)
                {
                    isholiday = true;
                    break;
                }
            }
            if (isholiday == true)
            {
                isholiday = false;
                startday = startday.AddDays(1);
                continue;
            }
            //check weekend
            if (startday.DayOfWeek == DayOfWeek.Saturday | startday.DayOfWeek == DayOfWeek.Sunday)
            {
                //check extraworkday
                foreach (DateTime extraworkday in extraworkdays)
                {
                    if (extraworkday == startday)
                    {
                        isextraworkday = true;
                        workday++;
                        break;
                    }
                }
                if (isextraworkday == true)
                {
                    isextraworkday = false;
                    startday = startday.AddDays(1);
                    continue;
                }
            }
            else
            {
                workday++;
            }
            startday = startday.AddDays(1);
        }
        Console.WriteLine("Workdays until {0} are: {1}", endday, workday);
    }
}

