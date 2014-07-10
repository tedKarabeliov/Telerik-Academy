using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class Element : IElement
    {
        private string name;
        private string textContent;
        private List<IElement> childElements;

        //Constructors
        public Element(string name)
            : this(name, null) { }
        public Element(string name, string textContent)
        {
            this.Name = name;
            this.TextContent = textContent;
            childElements = new List<IElement>();
        }
        //

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }
        public IEnumerable<IElement> ChildElements
        {
            get { return this.childElements; }
        }
        //

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public void Render(StringBuilder output)
        {
            //<(name)>(text_content)(child_content)</(name)>
            //<html><h1>Welcome!</h1></html>
            RenderNameOpen(output);
            RenderTextContent(output);
            RenderChildContent(output);
            RenderNameClose(output);
        }

        private void RenderNameOpen(StringBuilder output)
        {
            output.Append('<');
            output.Append(this.Name);
            output.Append('>');
        }

        private void RenderNameClose(StringBuilder output)
        {
            output.Append('<');
            output.Append('\\');
            output.Append(this.Name);
            output.Append('>');
        }

        private void RenderTextContent(StringBuilder output)
        {
            if (this.TextContent != null)
            {
                output.Append('<');
                this.TextContent = EscapeContent(TextContent);
                output.Append(this.TextContent);
                output.Append('>');
            }
        }

        private void RenderChildContent(StringBuilder output)
        {
            foreach (var childElement in this.ChildElements)
            {
                childElement.Render(output);
            }
        }

        private string EscapeContent(string textContent)
        {
            textContent = textContent.Replace("&", "&amp;");
            textContent = textContent.Replace("<", "&lt;");
            textContent = textContent.Replace(">", "&gt;");
           
            return textContent;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            Render(output);

            return output.ToString();
        }

        
    }
}
