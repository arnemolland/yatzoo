using System.Collections.Generic;

namespace Yatzoo.Models
{

    class Roller<T>
    {
        List<Die<T>> dice { get; set; }

        public Roller() { }

        T roll()
        {
            return EnumHelper.RandomEnum<T>();
        }
    }
}