using System.Collections.Generic;
using System.Linq;

namespace yatzoo.Models
{
    public class Scoreboard
    {
        public List<Score> board
        {
            get
            {
                return this.board.OrderBy(x => x.value).ToList();
            }
            set
            {
                this.board = value;
            }
        }

        public void updateScore(Score newScore)
        {
            var currentScore = board.Find(current => current.player.Equals(newScore.player));
            currentScore = newScore;
        }

        public void addScore(Score score)
        {
            board.Add(score);
        }

        public void removeScore(Score score)
        {
            board.Remove(board.Find(v => v.player.Equals(score.player)));
        }
    }
}