using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class Display
    {
        public void Subscribe(Timer timer)
        {
            timer.SecondChanged += new Timer.SecondChangeHandler(DisplayTime);;
        }

        public void DisplayTime(Timer timer, TimeInfoEventArgs timeInfo)
        {
            Console.WriteLine("Hello! Please wait for the next \"Hello after\" " + timeInfo.Second + " second(s)!");
        }
    }
}
