using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class GSM
{
    private static readonly string iphone4S = "Cool phone";
    private string brand;
    private double price;
    private string owner;
    public Battery battery;
    public Display display;
    public Call Call = new Call();

    //Constructors
    public GSM()
        : this("unnamed")
    {
    }
    public GSM(string brand)
        : this(brand, 0)
    {
    }
    public GSM(string brand, int price)
        : this(brand, price, "unnamed")
    {
    }
    public GSM(string brand, int price, string owner)
    {
        this.brand = brand;
        this.price = price;
        this.owner = owner;
        battery = new Battery();
        display = new Display();
    }
    //

    //Properties
    public string Brand
    {
        get { return brand; }
        set { this.brand = value; }
    }
    public double Price
    {
        get { return price; }
        set { this.price = value; }
    }
    public string Owner
    {
        get { return owner; }
        set { this.owner = value; }
    }
    public static string Iphone4S
    {
        get { return iphone4S; }
    }
    //Methods
    public override string ToString()
    {
        return "Brand - " + this.brand + "\n"
             + "Price - " + this.price + "$\n"
             + "Owner - " + this.owner + "\n"
             + "Battery Type - " + this.battery.BatteryType + "\n"
             + "Display size - " + this.display.Size + "\n"
             + "Display colors - " + this.display.Colors;
    }

    //
}


