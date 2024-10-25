using System;
using System.Text;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _domesticShippingCost = 5;
    private int _internationalShippingCost = 35;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double TotalCost()
    {
        double totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.TotalCost();
        }

        double shippingCost = _customer.IsInUsa() ? _domesticShippingCost : _internationalShippingCost;

        return totalProductCost + shippingCost;
    }

    public string PackingLabel()
    {
        StringBuilder label = new StringBuilder("PackingLabel:\n");

        foreach (var product in _products)
        {
            label.AppendLine($"Product Name: {product.GetName()}, Product ID: {product.GetProductID()}");
        }

        return label.ToString();
    }

    public string ShippingLabel(Address address, Customer customer)
    {
        return $"Shipping Label:\nName: {customer.GetName()}\nAddress: {address.GetAddress()}";
    }
}