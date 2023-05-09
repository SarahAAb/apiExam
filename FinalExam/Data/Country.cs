using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Data
{
    [Table("Countries")]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<City> Cities { get; set; }
    }
}
