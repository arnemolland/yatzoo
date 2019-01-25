namespace yatzoo.Models
{

    public class Score
    {
        public Player player { get; set; }
        public int value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value += value;
            }
        }

        public Score()
        {
            value = 0;
        }

        public Score(Player player)
        {
            this.value = 0;
            this.player = player;
        }
    }
}