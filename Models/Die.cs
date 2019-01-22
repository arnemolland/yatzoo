using System.Collections.Generic;
class Die<T>
{
    public List<T> eyes { get; set; }

    public Die() { }

    public Die(List<T> eyes) => this.eyes = eyes;

}