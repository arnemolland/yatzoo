using System.Collections.Generic;
using yatzoo.Helpers;
using System;
namespace yatzoo.Models
{

    public class Roller
    {
        public List<Die> dice { get; set; }

        public Roller() { }

        public Animal roll()
        {
            return EnumHelper.RandomEnum<Animal>();
        }
    }
}