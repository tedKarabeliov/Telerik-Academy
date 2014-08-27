using System;
using System.Collections.Generic;

namespace Trade_Company
{
    public class Article : IComparable<Article>
    {
        public int BarCode { get; set; }
        public string Vendor { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public Article(string title, int price)
        {
            this.Title = title;
            this.Price = price;
        }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
