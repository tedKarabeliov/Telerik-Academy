using System;

namespace HTMLRenderer
{
    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            IElement element = new HTMLElement(name);
            return element;
        }

        public IElement CreateElement(string name, string content)
        {
            IElement element = new HTMLElement(name, content);
            return element;
        }

        public ITable CreateTable(int rows, int cols)
        {
            ITable table = new HTMLTable(rows, cols);
            return table;
        }
    }
}
