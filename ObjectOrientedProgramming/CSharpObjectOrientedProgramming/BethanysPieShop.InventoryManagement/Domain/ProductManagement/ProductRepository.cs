﻿using BethanysPieShop.InventoryManagement.Domain.Contracts;
using BethanysPieShop.InventoryManagement.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.InventoryManagement.Domain.ProductManagement
{
    internal class ProductRepository
    {
        private string directory = @"D:\C#\C# Fundamentals\CSharpObjectOrientedProgramming\BethanysPieShop.InventoryManagement\";
        private string fileName = "product.txt";

        private void CheckForExistingProductFile()
        {
            string path = $"{directory}{fileName}";

            bool existingFileFound = File.Exists(path);
            if (!existingFileFound)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using FileStream fs = File.Create(path);
            }
        }

            public List<RegularProduct> LoadProductsFromFile()
            {
            List<RegularProduct> products = new List<RegularProduct>();

            string path = $"{directory}{fileName}";
            try
            {
                CheckForExistingProductFile();

                string[] productsAsString = File.ReadAllLines(path);
                for (int i = 0; i < productsAsString.Length; i++)
                {
                    string[] productSplits = productsAsString[i].Split(';');

                    bool success = int.TryParse(productSplits[0], out int productId);
                    if (!success)
                    {
                        productId = 0;
                    }

                    string name = productSplits[1];
                    string description = productSplits[2];

                    success = int.TryParse(productSplits[3], out int maxItemsInStock);
                    if (!success)
                    {
                        maxItemsInStock = 100;//default value
                    }

                    success = int.TryParse(productSplits[4], out int itemPrice);
                    if (!success)
                    {
                        itemPrice = 0;//default value
                    }

                    success = Enum.TryParse(productSplits[5], out Currency currency);
                    if (!success)
                    {
                        currency = Currency.Dollar;//default value
                    }


                    success = Enum.TryParse(productSplits[6], out UnitType unitType);
                    if (!success)
                    {
                        unitType = UnitType.PerItem;//default value
                    }

                    string productType = productSplits[7];

                    RegularProduct product = null;

                    switch (productType)
                    {
                        case "1":
                            success = int.TryParse(productSplits[8], out int amountPerBox);
                            if (!success)
                            {
                                amountPerBox = 1;//default value
                            }

                            product = new BoxedProduct(productId, name, description, new Price() { ItemPrice = itemPrice, Currency = currency }, maxItemsInStock, amountPerBox);
                            break;

                        case "2":
                            product = new FreshProduct(productId, name, description, new Price() { ItemPrice = itemPrice, Currency = currency }, maxItemsInStock, unitType);
                            break;
                        case "3":
                            product = new BulkProduct(productId, name, description, new Price() { ItemPrice = itemPrice, Currency = currency }, maxItemsInStock);
                            break;
                        case "4":
                            product = new RegularProduct(productId, name, description, new Price() { ItemPrice = itemPrice, Currency = currency }, maxItemsInStock, unitType);
                            break;
                    }

                    //Product product = new Product(productId, name, description, new Price() { ItemPrice = itemPrice, Currency = currency }, unitType, maxItemsInStock);


                    products.Add(product);

                }
                }

                catch (IndexOutOfRangeException iex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Something went wrong parsing the file, please check the data!");
                    Console.WriteLine(iex.Message);
                }
                catch (FileNotFoundException fnfex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The file couldn't be found!");
                    Console.WriteLine(fnfex.Message);
                    Console.WriteLine(fnfex.StackTrace);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Something went wrong while loading the file!");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ResetColor();
                }

                return products;
            }

        public void SaveToFile(List<ISaveable> saveables)
        {
            StringBuilder sb = new StringBuilder();
            string path = $"{directory}{fileName}";

            foreach (var item in saveables)
            {
                sb.Append(item.ConvertToStringForSaving());
                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved items successfully");
            Console.ResetColor();
        }

    }
}