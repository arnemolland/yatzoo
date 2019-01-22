static class EnumHelper {
    static T RandomEnum<T> () {
        var v = Enum.GetValues (typeof(T));
        return (T) v.getValue (new Random().Next(v.length));
    }

    static List<T> GetAllEnums<T> () {
       Enum.GetValues(typeof(T))
       .Cast<T>()
       .ToList();
    }
}