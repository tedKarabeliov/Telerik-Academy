using System;
using System.Collections.Generic;
using System.IO;

namespace Phones
{
    public static class TextParser
    {
        public static List<string>[] Parse(string path)
        {
            var reader = new StreamReader(path);
            var result = new List<List<string>>();

            using (reader)
            {
                var readLine = reader.ReadLine();
                while (readLine != null)
                {
                    var props = readLine.Split('|');
                    var propsList = new List<string>();

                    for (int i = 0; i < props.Length; i++)
                    {
                        propsList.Add(props[i].Trim());
                    }
                    result.Add(propsList);
                    readLine = reader.ReadLine();
                }
            }

            return result.ToArray();
        }
    }
}
