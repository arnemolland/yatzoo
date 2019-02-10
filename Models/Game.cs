using System;
using System.ComponentModel.DataAnnotations;
namespace yatzoo.Models
{

    public class Game
    {
        [Required]
        public string name { get; set; }
        public Guid id { get; set; }
        public Roller roller { get; set; }
        public GameState state { get; set; }
        public void setup()
        {

        }
    }
}