using System.ComponentModel.DataAnnotations;

namespace Cyclix.Models
{
    public class CycleType
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string lang { get; set; }
    }
}
