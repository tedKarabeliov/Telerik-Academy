using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
class Download
{
    static void Main()
    {
        string adress = @"http://www.telerik.com/images/newsletters/academy/assets/ninja-top.gif";
        string file = @"ninja-top.gif";
        WebClient web = new WebClient();
        web.DownloadFile(adress, file);
        
    }
}

