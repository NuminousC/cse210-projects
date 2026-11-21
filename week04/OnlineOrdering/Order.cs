using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double productTotal = 0;

        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        double shippingCost = 0;

        if (_customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label += product.GetName() + " (Product ID: " + product.GetProductId() + ")\n";
        }

        return label.TrimEnd();
    }

    public string GetShippingLabel()
    {
        return "SHIPPING LABEL\n"
            + _customer.GetName() + "\n"
            + _customer.GetAddress().GetFullAddress();
    }
}
