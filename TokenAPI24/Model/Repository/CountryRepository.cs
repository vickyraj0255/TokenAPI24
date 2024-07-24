using TokenAPI24.Model.Interface;
using TokenAPI24.Model.Request;

namespace TokenAPI24.Model.Repository
{
    public class CountryRepository : ICountry
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddCountry(CountryRequest countryRequest)// dto or request
        {
            try
            {
                Country country = new Country(); 
                country.Name = countryRequest.Name;
                _context.Countries.Add(country);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateCountry(CountryRequest countryRequest)
        {
            try
            {
                Country country = new Country();
                country.Id = countryRequest.Id;
                country.Name = countryRequest.Name;
                _context.Countries.Update(country);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCountry(int id)
        {
            try
            {
                var country = _context.Countries.Find(id);
                _context.Countries.Remove(country);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<CountryRequest> GetAllCountry()
        {
            var countrydata = _context.Countries.ToList();//we r fetching data from db in list
            List<CountryRequest> list = new List<CountryRequest>();//we have creates VM instance of list type.
            foreach (var country in countrydata)
            {
                CountryRequest countryRequest = new CountryRequest();//we have creates VM of instance in foreachloop
                countryRequest.Id = country.Id;
                countryRequest.Name = country.Name;
                list.Add(countryRequest);
            }
            return list;

        }

        public CountryRequest GetCountryBYId(int id)
        {
            var dataItem = _context.Countries.Find(id);
            CountryRequest countryRequest = new CountryRequest();
            countryRequest.Id = dataItem.Id;
            countryRequest.Name = dataItem.Name;
            return countryRequest;
        }
    }
}
