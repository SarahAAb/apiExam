using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Data
{
    [Table("Cities")]
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("country")]
        public int CountryId { get; set; }
        public Country country { get; set; }
    }
}
