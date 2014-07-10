using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Display
{
    private int length;
    private int width;
    private int colors;
    private string size = "0x0";

    //Constructors
    public Display()
        : this(0)
    {
    }
    public Display(int length)
        : this(length, 0)
    {
    }
    public Display(int length, int width)
        : this(length, width, 0)
    {
    }
    public Display(int length, int width, int colors)
    {
        this.length = length;
        this.width = width;
        this.colors = colors;
    }

    //Properties
    public int Length
    {
        get { return length; }
        set
        {
            this.length = value;
            ConvertToSize();
        }
    }
    public int Width
    {
        get { return width; }
        set
        {
            this.width = value;
            ConvertToSize();
        }
    }
    public int Colors
    {
        get { return colors; }
        set { this.colors = value; }
    }
    public string Size
    {
        get { return size; }
    }

    //Methods
    private void ConvertToSize()
    {
        if (length != 0 && width != 0)
        {
            string stringlength = length.ToString();
            string stringwidth = width.ToString();
            this.size = stringlength + "x" + stringwidth;
        }
    }
}

