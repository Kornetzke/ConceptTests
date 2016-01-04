using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DomainModels;
using System.Reflection;
using System.Diagnostics;

namespace Console
{
    class Program
    {
        static void ChangeByReference(ref Product itemRef)
        {
            itemRef = new Product("Stapler", 99999);
            itemRef.ItemID = 12345;
        }

        static void Main()
        {
            // Declare an instance of Product and display its initial values.
            Product item = new Product("Fasteners", 54321);
            System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);

            // Send item to ChangeByReference as a ref argument.
            ChangeByReference(ref item);
            System.Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);

            List<Product> products = new List<Product>()
            {
                new Product("Tim",2),
                new Product("Bob",5)
            };
        }
    }

    class Product
    {
        public Product(string name, int newID)
        {
            ItemName = name;
            ItemID = newID;
        }
        public User user { get; set; }
        public string ItemName { get; set; }
        public int ItemID { get; set; }
    }
    class User
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    // Output: 
    //Original values in Main.  Name: Fasteners, ID: 54321

    //Back in Main.  Name: Stapler, ID: 12345
}

