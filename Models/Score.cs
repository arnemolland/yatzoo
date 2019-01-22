namespace Yatzoo.Models
{

    public class Score
    {
        public Player player { get; set; }
        public int score { get; set; }

        public Score()
        {
            score = 0;
        }

        public Score(Player player)
        {
            this.score = 0;
            this.player = player;
        }
    }
}