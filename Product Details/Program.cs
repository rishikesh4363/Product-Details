using System;
using System.Collections.Generic;



namespace Product_Details
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> Product = new List<Products>();

            Console.WriteLine("------Product Details-----");
            bool ShowMenu = true;
            Console.WriteLine("-----SMARTPHONE STORE-----");
            while (ShowMenu)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Display all Products");
                Console.WriteLine("3. Delete a Product");
                Console.WriteLine("4. Delete All Products");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter the option");
                int option = Int16.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter Product id:");
                    int id = Int16.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Name:");
                    String name = (Console.ReadLine());
                    Console.WriteLine("Enter Product Model:");
                    String model = (Console.ReadLine());
                    Console.WriteLine("Enter Product Specifications:");
                    String specifications = (Console.ReadLine());
                    Console.WriteLine("Enter Product price");
                    int price = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Color");
                    string color = Console.ReadLine();
                    Products p = new Products();
                    p.id = id;
                    p.name = name;
                    p.price = price;
                    p.color = color;
                    p.model = model;
                    p.specifications = specifications;
                    Product.Add(p);
                    Console.WriteLine("Product Added Successfully");
                    Console.ReadLine();
                } else if (option == 2)
                {
                    foreach (Products p in Product)
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine("Product ID:" + p.id);
                        Console.WriteLine("Product Name:" + p.name);
                        Console.WriteLine("Product Model:" + p.model);
                        Console.WriteLine("Product Specifications:" + p.specifications);
                        Console.WriteLine("Product Price:" + p.price);
                        Console.WriteLine("Product Color:" + p.color);
                        Console.WriteLine("----------------");
                        Console.ReadLine();
                    }

                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter the index of the product you wish to delete:");
                    int index = Int16.Parse(Console.ReadLine());
                    Product.RemoveAt(index);
                    Console.WriteLine("Product Deleted Successfully");
                    
                    Console.WriteLine("The Remaining No of Products:" +Product.Count);
                    Console.ReadLine();
                }
                else if (option == 4)
                {
                    Product.Clear();
                    Console.WriteLine("All Products have been deleted");
                }
                
                else if (option==5)
            {
                Environment.Exit(0);
                /*here 0 means true ,1 means false*/
            }
            }

        }
    }
}
