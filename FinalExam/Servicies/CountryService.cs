using FinalExam.Data;
using FinalExam.Models;

namespace FinalExam.Servicies
{
    public class CountryService:ICountryService
    {
        FinalContext context;

        public CountryService(FinalContext _context) {
            context = _context;
        }
        public void Insert(CountryDTO countryDTO)
        {
            Country country = new Country()
            {
                Name= countryDTO.Name,
                Code= countryDTO.Code,
            };
            context.countries.Add(country);
            context.SaveChanges();
        }
        public List<CountryDTO> SearchByName(string cname)
        {
            List<Country> countries=context.countries.Where(a=>a.Name==cname).ToList();
            List<CountryDTO> countryDTOs=new List<CountryDTO>();
            foreach (Country country in countries)
            {
                countryDTOs.Add(new CountryDTO() {
                    Id= country.Id,
                    Name= country.Name,
                    Code= country.Code });
            }
            return countryDTOs;
        }
        public List<CountryDTO> GetAll()
        {
            List<Country> countries = context.countries.ToList();
            List<CountryDTO> countryDTOs = new List<CountryDTO>();
            foreach (Country country in countries)
            {
                countryDTOs.Add(new CountryDTO()
                {
                    Id = country.Id,
                    Name = country.Name,
                    Code = country.Code
                });
            }
            return countryDTOs;
        }

    }
}
