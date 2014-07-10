using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PDF : BinaryDocument, IEncryptable
{
    private bool isEncrypted;
    private int pages;

    public int Pages
    {
        get { return this.pages; }
        private set { this.pages = value; }
    }

    public bool IsEncrypted
    {
        get { return this.isEncrypted; }
        private set { this.isEncrypted = value; }
    }

    public void Encrypt()
    {
        this.IsEncrypted = true;
    }

    public void Decrypt()
    {
        this.IsEncrypted = false;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.Pages = int.Parse(value);
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("pages", this.Pages));
        base.SaveAllProperties(output);
    }
}

