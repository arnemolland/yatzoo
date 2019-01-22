using System.Collections.Generic;

namespace Yatzoo.Models
{
    class Die<T>
    {
        public List<T> eyes { get; set; }

        public Die() { }

        public Die(List<T> eyes) => this.eyes = eyes;

    }
}