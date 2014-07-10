using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Call
{
    private DateTime date;
    private DateTime begincall;
    private TimeSpan duration;
    private List<Call> history = new List<Call>();
    private static int callcounter = 1;
    private double callprice;
    private int callminutes;
    private string dialedNumber;

    //Methods
    public void StartCall(string dialedNumber)
    {
        this.date = DateTime.Today;
        this.begincall = DateTime.Now;
        this.dialedNumber = dialedNumber;
    }
    public void EndCall()
    {
        this.duration = DateTime.Now - begincall;
        history.Add(new Call());
        history[history.Count - 1].date = this.date;
        history[history.Count - 1].begincall = this.begincall;
        history[history.Count - 1].duration = this.duration;
        CallPrice();
    }
    public void DeleteCall(int callIndex)
    {
        callIndex--;
        try
        {
            if (callIndex >= 0 && callIndex < history.Count)
            {
                history.RemoveAt(callIndex);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Invalid index!");
        }
    }
    public void ShowHistory()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("Empty history");
        }
        else
        {
            for (int index = 0; index < history.Count; index++)
            {
                Console.WriteLine("Call " + callcounter + ":");
                Console.WriteLine("Date: " + date);
                Console.WriteLine("Dialed number: " + this.dialedNumber);
                Console.WriteLine("Call begin: " + begincall);
                Console.WriteLine("Call duration: " + duration + "\n");
                callcounter++;
            }
            callcounter = 1;
        }
    }
    public void DeleteHistory()
    {
        history.Clear();
    }
    private void CallPrice()
    {
        history[history.Count - 1].callminutes = duration.Minutes;
    }
    public double CalculatePrice(double priceperminute)
    {
        double sumprice = 0.37;
        for (int index = 0; index < history.Count; index++)
        {
            history[index].callprice = history[index].callminutes * priceperminute;
            sumprice += history[index].callprice;
        }
        return sumprice;
    }
}
