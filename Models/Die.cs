using System.Collections.Generic;

namespace yatzoo.Models
{
    public class Die
    {
        public List<Animal> eyes { get; set; }

        public Die() { }

        public Die(List<Animal> eyes) => this.eyes = eyes;

    }
}