using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public class TimeInfoEventArgs : EventArgs
    {
        public int Second { get; private set; }

        public TimeInfoEventArgs(int second)
        {
            this.Second = second;
        }
    }

    public class Timer
    {
        public int Second { get; private set; }

        public Timer(int second)
        {
            this.Second = second;
        }

        public delegate void SecondChangeHandler(
            Timer timer, TimeInfoEventArgs timeInfo);

        public event SecondChangeHandler SecondChanged;

        public void Run()
        {
            while (true)
            {
                TimeInfoEventArgs timeInfo = (
                    new TimeInfoEventArgs(this.Second));

                    if (SecondChanged != null)
                    {
                        SecondChanged(this, timeInfo);
                    }
                    Thread.Sleep(this.Second * 1000);
            }
        }
    }
}
