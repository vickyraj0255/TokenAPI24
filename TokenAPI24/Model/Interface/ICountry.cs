using TokenAPI24.Model.Request;

namespace TokenAPI24.Model.Interface
{
    public interface ICountry
    {
        bool AddCountry(CountryRequest countryRequest);
        bool UpdateCountry(CountryRequest countryRequest);
        bool DeleteCountry(int id);

        List<CountryRequest> GetAllCountry();
        CountryRequest GetCountryBYId(int id);
    }
}
