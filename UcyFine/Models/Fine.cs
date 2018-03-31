using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UcyFine.Models
{
    public class Fine
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public float Amount { get; set; }
        public ICollection<PlayerFine> PlayerFines { get; set; }
    }
}
