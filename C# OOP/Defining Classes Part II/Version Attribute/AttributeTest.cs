using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

//10. Create a [Version] attribute that can be applied to structures,
//classes, interfaces, enumerations and methods and holds a version
//in the format major.minor (e.g. 2.11). Apply the version attribute
//to a sample class and display its version at runtime.

namespace Version_Attribute
{
    [Version("2.11")]
    class AttributeTest
    {
        static void Main()
        {
            Type type = typeof(AttributeTest);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributes)
            {
                Console.WriteLine(attribute.Version);
            }
        }
    }

}
