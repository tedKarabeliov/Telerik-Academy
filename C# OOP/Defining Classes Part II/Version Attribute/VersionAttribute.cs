using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Version_Attribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class
    | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    class VersionAttribute : System.Attribute
    {
        private string version;

        public string Version 
        {
            get { return this.version; }
            private set { this.version = value; }
        }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
