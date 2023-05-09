using FinalExam.Models;

namespace FinalExam.Servicies
{
    public interface ICountryService
    {
        void Insert(CountryDTO countryDTO);
        List<CountryDTO> SearchByName(string cname);
        List<CountryDTO> GetAll();

    }
}
