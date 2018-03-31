using System;
using System.ComponentModel.DataAnnotations;

namespace UcyFine.Models
{
    public class PlayerFine
    {
        [Key]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int FineID { get; set; }
        public Fine Fine { get; set; }
        [Required]
        public int PlayerID { get; set; }
        public Player Player { get; set; }
    }
}
