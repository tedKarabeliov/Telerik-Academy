using System;
using System.Collections.Generic;
using System.Text;
namespace HTMLRenderer
{
    public class HTMLElement : IElement
    {
        private string name;
        private string textContent;
        private IList<IElement> childElements;

        public HTMLElement(string name)
            : this(name, null) { }
        public HTMLElement(string name, string textContent)
        {
            this.Name = name;
            this.TextContent = textContent;
            this.childElements = new List<IElement>();
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string TextContent
        {
            get { return this.textContent; }
            set { this.textContent = value; }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { return new List<IElement>(this.childElements); }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            // <(name)>(text_content)(child_content)</(name)>
            if (!String.IsNullOrEmpty(this.Name))
            {
                output.Append('<');
                output.Append(this.Name);
                output.Append('>');
            }

            if (!String.IsNullOrEmpty(this.TextContent))
            {
                string copyContent = String.Copy(this.TextContent);
                copyContent = this.TextContent.Replace("&", "&amp;");
                copyContent = this.TextContent.Replace("<", "&lt;");
                copyContent = this.TextContent.Replace(">", "&gt;");

                output.Append(copyContent);
            }
            foreach (var child in this.ChildElements)
            {
                child.Render(output);
            }
            if (!String.IsNullOrEmpty(this.Name))
            {
                output.Append("</");
                output.Append(this.Name);
                output.Append('>');
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            Render(output);
            return output.ToString();
        }
    }
}
