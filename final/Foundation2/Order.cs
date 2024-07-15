using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (Product product in _products)
        {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping To:\n{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }

    public bool IsShippingToUSA()
    {
        return _customer.IsCustomerInUSA();
    }
}
