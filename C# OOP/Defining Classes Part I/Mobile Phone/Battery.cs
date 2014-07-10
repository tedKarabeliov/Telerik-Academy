using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Battery
{
    public enum Type
    {
        LiIon, NiMH, NiCd
    }
    private string brand;
    private int idletime;
    private int hourstalk;
    private Type type;

    //Constructors
    public Battery()
        : this(null)
    {
    }
    public Battery(string brand)
        : this(brand, 0)
    {
    }
    public Battery(string brand, int idletime)
        : this(brand, idletime, 0)
    {
    }
    public Battery(string brand, int idletime, int hourstalk)
    {
        this.brand = brand;
        this.idletime = idletime;
        this.hourstalk = hourstalk;
    }

    //Properties
    public string Brand
    {
        get { return brand; }
        set { this.brand = value; }
    }
    public int Idletime
    {
        get { return idletime; }
        set { this.idletime = value; }
    }
    public int Hourstalk
    {
        get { return hourstalk; }
        set { this.hourstalk = value; }
    }
    public Type BatteryType
    {
        get { return type; }
        set { this.type = value; }
    }
}

