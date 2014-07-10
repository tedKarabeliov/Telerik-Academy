using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class OfficeDocument : BinaryDocument, IEncryptable
{
    private bool isEncrypted;
    private string version;

    public string Version
    {
        get { return this.version; }
        private set { this.version = value; }
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
        if (key == "version")
        {
            this.Version = value;
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("version", this.Version));
        base.SaveAllProperties(output);
    }
}

