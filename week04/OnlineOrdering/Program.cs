using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Set up a customer and address
        var address = new Address("275 Kandelaar", "Pretoria", "Gauteng", "South Africa");
        var customer = new Customer("Joshua Doe", address);

        // Create an order
        var order = new Order(customer);
        order.AddProduct(new Product("Stapler", "XOXO", 234, 1));
        order.AddProduct(new Product("WHooks", "DZZD", 15, 5));
        order.AddProduct(new Product("WBoard", "MNTX", 2009, 2));

        // Display the order
        Console.WriteLine($"Customer: {customer.GetCustomerName()}");
        Console.WriteLine($"Address: {customer.GetCustomerAddress()}");
        Console.WriteLine("Order Details:");
        foreach (var product in order.GetProducts())
        {
            Console.WriteLine(product.GetProductInfo());
        }
        Console.WriteLine($"Total Price: ${order.GetOrderTotal()}");
    }
}

public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_province}, {_country}";
    }
}

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        return _address.GetFullAddress();
    }
}

public class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _productQuantity;

    public Product(string name, string productId, int price, int productQuantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _productQuantity = productQuantity;
    }

    public int GetTotalPrice()
    {
        return _price * _productQuantity;
    }

    public string GetProductInfo()
    {
        return $"{_name} (ID: {_productId}) - Quantity: {_productQuantity}, Unit Price: {_price}, Total: {GetTotalPrice()}";
    }
}

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int GetOrderTotal()
    {
        int total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        return total;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
}
<<<<<<< HEAD
=======


>>>>>>> cc558b7c7f190c49aa4fa73a652acbaa886445b6
