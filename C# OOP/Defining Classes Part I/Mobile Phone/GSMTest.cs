using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class GSMTest
{
    private static void InitializeArray(GSM[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new GSM();
        }
    }

    static void Main()
    {
        GSM gsm1 = new GSM("Nokia", 1000, "Me");
        GSM[] arr = new GSM[3];
        InitializeArray(arr);
        arr[0].Brand = "Huawei";
        arr[1].Owner = "Fernando";
        arr[2].Price = 5;

        gsm1.Call.StartCall("0882989048");
        //Time is calculated between StartCall and EndCall
        gsm1.Call.EndCall();

        gsm1.Call.StartCall("0882989048");
        gsm1.Call.EndCall();

        Console.WriteLine(gsm1.ToString());
        Console.WriteLine(gsm1.Call.CalculatePrice(0.37));

        gsm1.Call.ShowHistory();

        gsm1.Call.DeleteCall(2);
        Console.Clear();
        gsm1.Call.ShowHistory();
        gsm1.Call.DeleteCall(1);
        gsm1.Call.ShowHistory();

    }
}

