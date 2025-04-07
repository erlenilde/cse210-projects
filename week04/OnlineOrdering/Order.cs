public class Order{

private List<Product> _products;
private Customer _customer;

public Order(List<Product> products, Customer customer)
{
    _products = products;
    _customer = customer;

}

float GetShippingCost()
{
    if (_customer.IsInUSA())
        {
        return 5;
        }
        else
        {
        return  35;
        }
    }



public double GetCostOrder()
{
    double total = 0;
    foreach (Product product in _products)
    {
        total += product.GetTotalCost();

    }

    return total + GetShippingCost();
}

public string GetPackingLabel()
{
    string label = "";

    foreach (Product product in _products)
    {
        label += product.GetPackingLabel() + "\n";

    }

    return label;
}

public string GetShippingLabel()
{
    return  $"\n{_customer.GetCustomerName()}\n{_customer.GetAddress().GetFullAddress()}";
}


}