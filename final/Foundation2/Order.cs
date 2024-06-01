using System.Collections.Generic;
using System.Text;

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

        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            totalCost += 5; // USA shipping cost
        }
        else
        {
            totalCost += 35; // International shipping cost
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();

        foreach (var product in _products)
        {
            packingLabel.AppendLine($"{product.Name} (Product ID: {product.ProductId})");
        }

        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();

        shippingLabel.AppendLine(_customer.Name);
        shippingLabel.AppendLine(_customer.Address.GetFullAddress());

        return shippingLabel.ToString();
    }

    public List<Product> Products => _products;
    public Customer Customer => _customer;
}
