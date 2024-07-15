public class Product
{
    private string _name;
    private string _productCode;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productCode, double pricePerUnit, int quantity)
    {
        _name = name;
        _productCode = productCode;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductDetails()
    {
        return $"{_name} ({_productCode}) - {_quantity} units @ ${_pricePerUnit} each";
    }
}
