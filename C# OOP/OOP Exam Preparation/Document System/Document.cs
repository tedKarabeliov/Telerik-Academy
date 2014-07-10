using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Document : IDocument
{
    private string name;
    private string content;

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public string Content
    {
        get { return this.content; }
        set { this.content = value; }
    }

    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.Name = value;
        }
        else if (key == "content")
        {
            this.Content = value;
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string,object>("name", this.Name));
        output.Add(new KeyValuePair<string,object>("content", this.Content));
    }

    public override string ToString()
    {
        IList<KeyValuePair<string, object>> output = new List<KeyValuePair<string, object>>();
        SaveAllProperties(output);
        var sortedOutput = output.OrderBy(k => k.Key);

        StringBuilder result = new StringBuilder("[");
        foreach (var pair in output)
        {
            if (pair.Value != null)
            {
                result.Append(pair.Key + "=" + pair.Value + ";");
            }
        }
        result[result.Length - 1] = ']';
        return result.ToString();
    }
}

