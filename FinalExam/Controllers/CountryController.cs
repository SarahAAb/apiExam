using FinalExam.Models;
using FinalExam.Servicies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        ICountryService countryService;

        public CountryController(ICountryService _countryService)
        {
            countryService = _countryService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(CountryDTO countryDTO)
        {
            countryService.Insert(countryDTO);
        }
        [HttpGet]
        [Route("Search")]
        public List<CountryDTO> Get(string name)
        {
            return countryService.SearchByName(name);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<CountryDTO> GetAll()
        {
            return countryService.GetAll();
        }
    }
}
