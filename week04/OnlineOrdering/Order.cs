using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _productList;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product product in _productList)
        {
            total += product.GetTotalCost();
        }

        float shippingCost = 0;

        if (_customer.IsInUSA())
        {
            shippingCost = 5.00f;
        }
        else
        {
            shippingCost = 35.00f;
        }

        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _productList)
        {
            label += $"Product: {product.GetNameProduct()}, ID: {product.GetProductId()}\n";
        }

        return label;
    }
    
    public string GetShippingLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress().GetAddress();

        string label = "Shipping Label:\n";
        label += $"Customer: {customerName}\n";
        label += $"Address:\n{customerAddress}";

        return label;
    }
}