using System.Collections.Generic;

namespace yatzoo.Models
{
    class Die
    {
        public List<Animal> eyes { get; set; }

        public Die() { }

        public Die(List<Animal> eyes) => this.eyes = eyes;

    }
}