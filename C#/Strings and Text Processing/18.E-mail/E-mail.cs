using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class Email
{
    static void Main()
    {
        string text = "Please contact by phone (+359 222 222 222) or by email at example@abv.bg or at baj.inva@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string pattern = @"[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}";
        Regex rgx = new Regex(pattern);

        MatchCollection matches = rgx.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }  
    }
}

