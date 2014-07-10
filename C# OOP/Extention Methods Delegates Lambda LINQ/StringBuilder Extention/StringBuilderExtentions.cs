using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringBuilderExtentions
{
    public static class StringBuilderExtentions
    {
        public static StringBuilder Substring(
            this StringBuilder builder, int index, int length)
        {
            string str = builder.ToString();
            builder.Clear();

            str = str.Substring(index, length);
            builder.Append(str);

            return builder;
        }
    }
}
