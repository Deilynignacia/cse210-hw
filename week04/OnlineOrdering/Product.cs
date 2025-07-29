public class Product
{
    private string _nameProduct;
    private string _id;
    private float _price;
    private int _quantity;

    public Product(string nameProduct, string id, float price, int quantity)
    {
        _nameProduct = nameProduct;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public float GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetNameProduct()
    {
        return _nameProduct;
    }

    public string GetProductId()
    {
        return _id;
    }
}
