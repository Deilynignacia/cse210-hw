public class Customer
{
    private string _name;
    private Adress _adress;

    public Customer(string name, Adress adress)
    {
        _name = name;
        _adress = adress;
    }

    public bool IsInUSA()
    {
        return _adress.USA();
    }

    public string GetName()
    {
        return _name;
    }

    public Adress GetAdress()
    {
        return _adress;
    }
}