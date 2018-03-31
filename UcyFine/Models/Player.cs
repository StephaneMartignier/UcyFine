using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UcyFine.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public ICollection<PlayerFine> PlayerFines { get; set; }
    }
}
