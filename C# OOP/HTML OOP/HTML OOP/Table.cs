using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class Table : ITable
    {
        private int rows;
        private int cols;
        private IElement[,] table;

        public Table(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            table = new IElement[rows, cols];
        }

        //Properties
        public int Rows
        {
            get { return this.rows; }
            set { this.rows = value; }
        }
        public int Cols
        {
            get { return this.cols; }
            set { this.cols = value; }
        }
        //

        public IElement this[int row, int col]
        {
            get { return table[row, col]; }
            set { table[row, col] = value; }
        }

        public void Render(StringBuilder output)
        {
            //<table><tr><td>(cell_0_0)</td><td>(cell_0_1)</td>…</tr><tr><td>(cell_1_0)</td><td>(cell_1_1)</td>…</tr>…</table>
            output.Append("<table>");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                output.Append("<tr>");
                for (int k = 0; k < table.GetLength(1); k++)
                {
                    output.Append("<td>");
                    output.Append(table[i, k].ToString());
                    output.Append("</td>");
                }
                output.Append("</tr>");
            }
            output.Append("</table>");
        }


        public string Name
        {
            get { throw new NotImplementedException(); }
        }
        public string TextContent
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public IEnumerable<IElement> ChildElements
        {
            get { throw new NotImplementedException(); }
        }
        public void AddElement(IElement element)
        {
            throw new NotImplementedException();
        }
    }
}
