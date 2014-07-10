using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Dates2
{
    static string Translate(int day)
    {
        switch (day)
        {
            case 1: return "Понеделник";
            case 2: return "Вторник";
            case 3: return "Сряда";
            case 4: return "Четвъртък";
            case 5: return "Петък";
            case 6: return "Събота";
            case 7: return "Неделя";

            default: return null;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter date and time in format \"dd.mm.yyyy h:m:s\"");
        string[] input = Console.ReadLine().Split(' ', '.', ':');
        DateTime time = new DateTime(int.Parse(input[2]), int.Parse(input[1]), int.Parse(input[0]), int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]));
        time = time.AddMinutes(390);
        Console.WriteLine("Date and time after 6 hours and 30 minutes: " + time + " - " + Translate(Convert.ToInt32(time.DayOfWeek)));
    }
}

