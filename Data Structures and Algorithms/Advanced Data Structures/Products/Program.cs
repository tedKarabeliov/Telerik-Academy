using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Wintellect.PowerCollections;

namespace Products
{
    /// <summary>
    /// Creating the products and printing them in the console is slow but the searches
    /// only take about 2 milliseconds to find the products within the specified price range.
    /// </summary>
    class Program
    {
        private static string GenerateName(Random rand)
        {
            var newProductName = new StringBuilder();

            var newProductNameLength = rand.Next(3, 10);
            for (int i = 0; i < newProductNameLength; i++)
            {
                var newProductLetter = (char)rand.Next(97, 122);
                newProductName.Append(newProductLetter);
            }
            return newProductName.ToString();
        }

        private static int GenerateNumber(Random rand)
        {
            return rand.Next(1, 1000);
        }
        static void Main()
        {
            const int ProductsCount = 500000;
            var products = new OrderedBag<Product>();

            //I have created only one random generator so it can generate different numbers.
            var rand = new Random();
            for (int i = 0; i < ProductsCount; i++)
            {
                var productName = GenerateName(rand);
                var productPrice = GenerateNumber(rand);
                var newProduct = new Product(productName, productPrice);
                products.Add(newProduct);
            }
            const int searches = 10000;
            for (int i = 0; i < searches; i++)
            {
                var minimumPriceSearch = GenerateNumber(rand);
                var maximumPriceSearch = GenerateNumber(rand);
                
                var foundProducts = products.Range(new Product("", minimumPriceSearch), true, new Product("", maximumPriceSearch), true);
                var result = new List<Product>();
                for (int k = 0; k < 20 && k < foundProducts.Count; k++)
                {
                    result.Add(foundProducts[k]);
                }
                foreach (var product in result)
                {
                    Console.WriteLine(product.Name + " " + product.Price);
                }
            }
        }
    }
}
