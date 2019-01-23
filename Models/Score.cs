namespace yatzoo.Models
{

    public class Score
    {
        public Player player { get; set; }
        public int score
        {
            get
            {
                return score;
            }
            set
            {
                score += value;
            }
        }

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