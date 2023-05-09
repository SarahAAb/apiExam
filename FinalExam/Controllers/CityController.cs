using FinalExam.Models;
using FinalExam.Servicies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        ICityService cityService;

        public CityController(ICityService cityService) {
            this.cityService = cityService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(CityDTO cityDTO)
        {
            cityService.Insert(cityDTO);
        }
        [HttpGet]
        [Route("Delete")]
        public void Delete(int id)
        {
            cityService.Delete(id);
        }
        [HttpGet]
        [Route("GetCities")]
        public List<CityDTO> load(int countryid)
        {
            return cityService.GetCities(countryid);
        }
    }
}
