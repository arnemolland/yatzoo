using Die;
using System.Collections.Generic;

class Roller
{
    List<Die> dice { get; set; }

    public Roller() { }

    void roll()
    {
        foreach (var die in dice)
        {
            var type = die.GetType();
            die = EnumHelper.GetRandomEnum<type>();
        }
    }
}