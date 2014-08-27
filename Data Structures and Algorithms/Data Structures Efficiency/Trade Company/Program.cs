using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace Trade_Company
{
    class Program
    {
        private static string GenerateString(Random rand)
        {

            string articleName = "";

            for (int i = 0, articleNameLength = rand.Next(3, 6); i < articleNameLength; i++)
            {
                articleName += (char)rand.Next(97, 122);
            }

            return articleName;
        }

        private static int GenerateNumber(Random rand)
        {
            return rand.Next(1, 10000);
        }

        static void Main()
        {
            const int NumberOfArticles = 500000;

            var dictionary = new OrderedMultiDictionary<int, Article>(true);
            var rand = new Random();

            for (int i = 0; i < NumberOfArticles; i++)
            {
                var newArticleName = GenerateString(rand);
                var newArticle = new Article(GenerateString(rand), GenerateNumber(rand));
                dictionary.Add(newArticle.Price, newArticle);
            }

            var partOfArticles = dictionary.Range(5, true, 1000, true);
            var anotherPartOfArticles = dictionary.Range(10, true, 6000, true);
        }
    }
}
