public class Address
{
    private string _street;
    private string _city;
    private string _stateorprovince;
    private string _country;

    public Address(string street, string city, string state, string country)
        {
        _street = street;
        _city = city;
        _stateorprovince = state;
        _country = country;
        }

    public bool IsCountryUsa()
           {
                return _country.ToUpper() == "USA";
            }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_stateorprovince}, {_country}";
    }

  }