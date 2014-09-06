namespace Proccessing_JSON
{
    using System;
    using System.Net;
    using Newtonsoft.Json;
    using System.Xml.Linq;
    using Newtonsoft.Json.Linq;
    using System.Text;

    public class ProccessingJSON
    {
        static void Main()
        {
            // Using JSON.NET and the Telerik Academy Forums RSS feed implement the following:

            // The RSS feed is at http://forums.academy.telerik.com/feed/qa.rss 
            // Download the content of the feed programmatically

            const string path = "../../rss-feed.xml";

            var webClient = new WebClient();
            webClient.DownloadFile("http://forums.academy.telerik.com/feed/qa.rss", "../../rss-feed.xml");
            var xml = XDocument.Load(path);

            // Parse the XML from the feed to JSON

            var json = JsonConvert.SerializeXNode(xml, Formatting.Indented);

            // Using LINQ-to-JSON select all the question titles and print them to the console
            var jsonObj = JObject.Parse(json);
            var items = jsonObj["rss"]["channel"]["item"];

            foreach (var item in items)
            {
                Console.WriteLine(item["title"]);
            }

            // Parse the JSON string to POCO
            var poco = JsonConvert.DeserializeObject<RootObject>(json);

            // Using the parsed objects create a HTML page that lists
            // all questions from the RSS their categories and a link to the question's page

            StringBuilder html = new StringBuilder("<body>\n\t<ul>\n");
            foreach (var item in poco.Rss.Channel.Item)
            {
                html.AppendLine("\t\t<li>Question : " + item.Title + " Category : " + item.Category + "Link : " + item.Link + "</li>");
            }

            html.AppendLine("\t</ul>\n</body>");
            Console.WriteLine(html);
        }
    }
}
