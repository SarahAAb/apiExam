using FinalExam.Data;
using FinalExam.Models;

namespace FinalExam.Servicies
{
    public class CityService:ICityService
    {
        FinalContext context;

        public CityService(FinalContext _context) {
            context = _context;
        }
        public void Insert(CityDTO cityDTO)
        {
            City city = new City()
            {
                Name= cityDTO.Name,
                CountryId=cityDTO.CountryId
            };
            context.cities.Add(city);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            City city = context.cities.Find(id);
            context.cities.Remove(city);
            context.SaveChanges();
        }
        public List<CityDTO> GetCities(int countryId) 
        {
            List<City> cities=context.cities.Where(a=>a.CountryId==countryId).ToList();
            List<CityDTO> cityDTOs=new List<CityDTO>();
            foreach (City city in cities)
            {
                cityDTOs.Add(new CityDTO() { 
                    Id=city.Id,
                    Name= city.Name,
                    CountryId=city.CountryId,
                    
                });
            }
            return cityDTOs;
        }

    }
}
