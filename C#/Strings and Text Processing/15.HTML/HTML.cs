using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class HTML
{
    static void Main()
    {
        string pattern1 = ("<a href");
        string pattern2 = ("</a>");
        string replacement1 = "[URL";
        string replacement2 = "[/URL]";
        Regex rgx1 = new Regex(pattern1);
        Regex rgx2 = new Regex(pattern2);
        string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        text = rgx1.Replace(text, replacement1);
        text = rgx2.Replace(text, replacement2);
        Console.WriteLine(text);
    }
}

