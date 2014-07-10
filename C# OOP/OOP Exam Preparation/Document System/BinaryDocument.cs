using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class BinaryDocument : Document
{
    private int size;

    public int Size
    {
        get { return this.size; }
        private set { this.size = value; }
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "size")
        {
            this.Size = int.Parse(value);
        }
        base.LoadProperty(key, value);
    }
}