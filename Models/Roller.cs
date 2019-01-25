using System.Collections.Generic;
using yatzoo.Helpers;
using System;
namespace yatzoo.Models
{

    public class Roller
    {
        List<Die> dice { get; set; }

        public Roller() { }

        Animal roll()
        {
            return EnumHelper.RandomEnum<Animal>();
        }
    }
}