using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TextDocument : Document, IEditable
{
    private string charset;

    public string Charset
    {
        get { return this.charset; }
        private set { this.charset = value; }
    }

    public void ChangeContent(string newContent)
    {
        throw new NotImplementedException();
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "charset")
        {
            this.Charset = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string,object>("charset", this.Charset));
        base.SaveAllProperties(output);
    }

    public override string ToString()
    {
        string type = this.GetType().ToString();
        return type + base.ToString();
    }
}