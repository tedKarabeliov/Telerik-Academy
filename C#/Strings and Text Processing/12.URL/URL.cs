using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class URL
{
    static void Main()
    {
        string url = @"http://www.devbg.org/forum/index.php";

        StringBuilder builder = new StringBuilder();
        int i = 0;
        while (url[i] != ':')
        {
            builder.Append(url[i]);
            i++;
        }
        string protocol = builder.ToString();
        builder.Clear();

        i += 3;
        while (url[i] != '/')
        {
            builder.Append(url[i]);
            i++;
        }
        string server = builder.ToString();
        builder.Clear();

        i++;
        while (i < url.Length)
        {
            builder.Append(url[i]);
            i++;
        }
        string resource = builder.ToString();

        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);

    }
}

