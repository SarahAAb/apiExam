using FinalExam.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Models
{
    public class CityDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
       
        public int CountryId { get; set; }
       // public CountryDTO? country { get; set; }
    }
}
