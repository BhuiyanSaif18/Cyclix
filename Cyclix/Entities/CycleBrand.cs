using System.ComponentModel.DataAnnotations;

namespace Cyclix.Models
{
    public class CycleBrand
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }
}
