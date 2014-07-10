using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Word : OfficeDocument, IEditable
{
    private int chars;

    public int Chars
    {
        get { return this.chars; }
        private set { this.chars = value; }
    }

    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
        {
            this.Chars = int.Parse(value);
        }
        base.LoadProperty(key, value);
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("chars", this.Chars));
    }
}

