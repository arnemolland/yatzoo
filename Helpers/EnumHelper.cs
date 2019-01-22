using System.Collections.Generic;
using System;
using System.Linq;

namespace Yatzoo
{

    public static class EnumHelper
    {
        public static T RandomEnum<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random().Next(v.Length));
        }

        public static List<T> GetAllEnums<T>()
        {
            return Enum.GetValues(typeof(T))
            .Cast<T>()
            .ToList();
        }
    }
}