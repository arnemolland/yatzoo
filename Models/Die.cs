
using Animals;
using AnimalsHelper;
using System.Collections.Generic;
class Die<T>
{
    List<T> eyes { get; set; }
    int faces { get; set; }

    public Die() { }
    
    public Die(List<T> eyes, int faces) {
        this.eyes = eyes;
        this.faces = faces;
    }

    public Die(int faces) => this.faces = faces;

    public Die(List<T> eyes) => this.eyes = eyes;

}