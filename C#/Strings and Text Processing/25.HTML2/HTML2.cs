using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HTML2
{
    static void Main()
    {
        string text = "<html><head><title>News</title></\">TelerikAcademy<a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

        StringBuilder builder = new StringBuilder();
        bool tagEnded = false;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                while (i < text.Length)
                {
                    if (text[i] == '>')
                    {
                        tagEnded = true;
                        break;
                    }
                    i++;
                }
            }
            else
            {
                if (tagEnded)
                {
                    tagEnded = false;
                    builder.Append("\n");
                }
                builder.Append(text[i]);
            }
        }
        builder.Remove(0, 1);
        string result = builder.ToString();
        Console.WriteLine(result);

    }
}

