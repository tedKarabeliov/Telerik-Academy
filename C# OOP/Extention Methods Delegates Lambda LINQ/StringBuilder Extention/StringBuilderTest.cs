using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Implement an extension method Substring(int index, int length)
//for the class StringBuilder that returns new StringBuilder and
//has the same functionality as Substring in the class String.

namespace StringBuilderExtentions
{
    class StringBuilderTest
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("pe6o stana banalen primer veche");
            builder = builder.Substring(5, 6);
        }
    }
}
