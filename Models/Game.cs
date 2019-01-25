namespace yatzoo.Models
{

    interface Game
    {
        string name { get; set; }
        void setup();
    }
}