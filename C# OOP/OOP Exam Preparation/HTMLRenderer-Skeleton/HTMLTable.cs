using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLRenderer
{
    public class HTMLTable : HTMLElement, ITable
    {
        private IElement[,] tableElements;
        private int rows;
        private int cols;

        public HTMLTable(int rows, int cols)
            : base("table", null)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.tableElements = new HTMLElement[this.Rows, this.Cols];
        }

        public int Rows
        {
            get { return this.rows; }
            private set { this.rows = value; }
        }

        public int Cols
        {
            get { return this.cols; }
            private set { this.cols = value; }
        }

        public IElement this[int row, int col]
        {
            get { return this.tableElements[row, col]; }
            set { this.tableElements[row, col] = value; }
        }

        public override void Render(StringBuilder output)
        {
            // <table><tr><td>(cell_0_0)</td><td>(cell_0_1)</td>…</tr><tr><td>(cell_1_0)</td><td>(cell_1_1)</td>…</tr>…</table>
            output.Append("<table>");
            for (int row = 0; row < this.tableElements.GetLength(0); row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.tableElements.GetLength(1); col++)
                {
                    output.Append("<td>");
                    output.Append(this[row, col]);
                    output.Append("</td>");
                }
                output.Append("</tr>");
            }
            output.Append("</table>");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            Render(output);
            return output.ToString();
        }
    }
}
