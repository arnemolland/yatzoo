using System.Collections.Generic;
using yatzoo.Helpers;
namespace yatzoo.Models
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