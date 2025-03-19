using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8;

class Product
{
    public string name;
    public string description;
    public int Count;
    public bool IsStock { get { return Count > 0; } }
    private double _price;
    public double Price { get { return _price; } set { _price = value; } }

    public Product(string name, string description, int count, double price)
    {
        this.name = name;
        this.description = description;
        Count = count;
        Price = price;
    }


    public void Sale()
    {
        if (IsStock)
        {
            Count--;
            Console.WriteLine("Product is sold");
        }
        else
        {
            Console.WriteLine("Product is out of stock");
        }
    }
}

class Notebook : Product
{
    public int storage;
    private byte _RAM;
    public byte RAM { get { return _RAM; } set { _RAM = value; } }

    public Notebook(string name, string description, int count, double price, int storage, byte RAM) : base(name, description, count, price)
    {
        this.storage = storage;
        this.RAM = RAM;
    }

    public string FullInfo()
    {

        return $"Name : {name},Description : {description},Storage: {storage} GB\nRAM: {RAM} GB";
    }


    public void ShowFulldata()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Count: {Count}");
        Console.WriteLine($"IsStock: {IsStock}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Storage: {storage}");
        Console.WriteLine($"RAM: {RAM}");
    }


}

