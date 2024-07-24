using Microsoft.AspNetCore.Mvc;
using TokenAPI24.Model.Interface;
using TokenAPI24.Model.Request;
namespace TokenAPI24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        
            private readonly ICountry _country;  
        public CountriesController(ICountry country)
        {
            _country = country;
        }


        [Route("GetAllCountry")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_country.GetAllCountry());
        }



        [Route("GetCountryBYId")]
        [HttpGet]
        public IActionResult GetCountryBYId(int id)
        {
            return Ok(_country.GetCountryBYId(id));
        }

        [Route("AddCountry")]
        [HttpPost]
        public IActionResult AddCountry(CountryRequest countryRequest)
        {
            return Ok(_country.AddCountry(countryRequest));

        }

        [Route("UpdateCountry")]
        [HttpPut]
        public IActionResult UpdateCountry(CountryRequest countryRequest)
        {
            return Ok(_country.UpdateCountry(countryRequest));
        }

        [Route("DeleteCountry")]
        [HttpDelete]
        public IActionResult DeleteCountry(int id)
        {
            return Ok(_country.DeleteCountry(id));

        }
    }
}
