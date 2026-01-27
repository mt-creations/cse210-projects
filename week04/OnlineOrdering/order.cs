

using System.Runtime.InteropServices.Marshalling;

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

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculateTotalCost();
        }

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label" + Environment.NewLine;

        foreach (Product product in _products)
        {
            label += product.GetName() + " Product ID: " + product.GetProductId() + Environment.NewLine;
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label" + Environment.NewLine;

        label += _customer.GetName() + Environment.NewLine;
        label += _customer.GetAddress().GetFullAddress();

        return label;
    }
}