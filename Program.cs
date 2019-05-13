using System;
using System.Collections.Generic;
using ConsoleProduct.Entities;

namespace ConsoleProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            byte trava = 1;
            while (trava!=0)
            {
                List<Product> products = new List<Product>();
                Console.Write("Enter the number of products:  " );
                int n = int.Parse(Console.ReadLine());

                for(int i =1; i<=n; i++)
                {
                    Console.WriteLine($"Product #{i} data:");
                    Console.Write("Common, used or imported ? (c,u,i):  ");
                    string ch = Console.ReadLine();
                    ch.ToLower();
                    Console.Write("Name:  ");
                    string name = Console.ReadLine();
                    Console.Write("Price:  ");
                    double price = double.Parse(Console.ReadLine());
                    if(ch == "u")
                    {
                        Console.Write("Manufacture date (DD/MM/YYYY):  ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, date));
                    }
                    else if (ch =="i")
                    {
                        Console.Write("Custom fee:  ");
                        double fee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, fee));
                    }
                    else
                    {
                        products.Add(new Product(name, price));
                    }
                }

                Console.WriteLine("\nPRICE TAGS:");
                foreach(Product product in products)
                {
                    Console.WriteLine(product.PriceTag());
                }

                Console.WriteLine("Type 0 to quit application...");
                trava = byte.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
