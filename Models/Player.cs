using System;
using System.ComponentModel.DataAnnotations;

namespace yatzoo.Models
{

    public class Player
    {
        public string name { get; set; }
        [Required]
        [Key]
        public Guid id { get; set; }

        public Player() { }
    }
}