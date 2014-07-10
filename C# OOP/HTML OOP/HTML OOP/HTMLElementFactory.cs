using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            Element element = new Element(name);
            return element;
        }

        public IElement CreateElement(string name, string content)
        {
            Element element = new Element(name, content);
            return element;
        }

        public ITable CreateTable(int rows, int cols)
        {
            Table table = new Table(rows, cols);
            return table;
        }
    }
}
