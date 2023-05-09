using FinalExam.Models;

namespace FinalExam.Servicies
{
    public interface ICityService
    {
        void Insert(CityDTO cityDTO);
        void Delete(int id);
        List<CityDTO> GetCities(int countryId);
    }
}
