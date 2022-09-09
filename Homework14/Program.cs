using System;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            Coconut infoCoconut = new Coconut();
            infoCoconut.info();
            infoCoconut.price();
            infoCoconut.quantity();
            infoCoconut.moreInfo();
            Console.WriteLine("\n");
            infoCoconut.add();
            Console.WriteLine("Success!");

            NewBuyer buyer = new NewBuyer();
            Console.WriteLine(buyer.registerBuyer());

            NewProduct product = new NewProduct();
            Console.WriteLine(product.registerProduct());
        }
    }

    abstract class ProductInfo
    {
        public abstract void info();
        public abstract void price();

        public abstract void quantity();

        public void moreInfo()
        {
            Console.WriteLine("---For more info ask the seller---");
        }
    }

    class Coconut : ProductInfo, IQuantity
    {
        public override void info()
        {
            string name = "Coconut";
            string country = "Brazil";
            Console.WriteLine("---Product info---");
            Console.WriteLine($"Product name: {name} \nCountry: {country}");
        }

        public override void price()
        {
            int netPrice = 5;
            int tax = 1;
            int total = tax + netPrice;
            Console.WriteLine($"Price: {total}$");
        }

        public override void quantity()
        {
            int inStock = 1500;
            int spoiled = 350;
            int avaiable = inStock - spoiled;
            Console.WriteLine($"Avaiable on sell: {avaiable} coconuts");
        }

        public int add()
        {
            Console.WriteLine($"Please, add some quantity to the item coconut");
            int addItem = int.Parse(Console.ReadLine());
            return addItem;
        }
    }

    interface INewProduct
    {
        string registerProduct();
    }

    interface INewBuyer
    {
        string registerBuyer();
    }

    interface IQuantity
    {
        int add();
    }

    class NewBuyer : INewBuyer
    {
        public string registerBuyer()
        {
            Console.WriteLine("\nHi, please, enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Now, enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Last step - enter your email");
            string email = Console.ReadLine();
            string space = " ";
            Console.WriteLine($"\nThank you for registration, your info:");
            return name + space + surname + space + email;
        }
    }

    struct NewProduct : INewProduct
    {
        public string registerProduct()
        {
            Console.WriteLine("\nHi,please, enter item name");
            string itemName = Console.ReadLine();
            Console.WriteLine("\nNow, enter price");
            string itemPrice = Console.ReadLine();
            string space = " ";
            Console.WriteLine("\nNew product info:");
            return itemName + space + itemPrice;
        }
    }
}