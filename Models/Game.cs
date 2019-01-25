using System;
using System.ComponentModel.DataAnnotations;
namespace yatzoo.Models
{

    public class Game
    {
        [Required]
        public string name { get; set; }
        public Guid id { get; set; }
        Roller roller { get; set; }
        GameState state { get; set; }
        void setup()
        {

        }
    }
}