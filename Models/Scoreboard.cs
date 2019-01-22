using System.Collections.Generic;
using System.Linq;

namespace Yatzoo
{
    class Scoreboard
    {
        List<Score> board { get; set; }

        void updateScore(Score newScore)
        {
            var currentScore = board.Find(current => current.player.Equals(newScore.player));
            currentScore = newScore;
        }

        void addScore(Score score)
        {
            board.Add(score);
        }

        void removeScore(Score score)
        {
            board.Remove(board.Find(v => v.player.Equals(score.player)));
        }
    }
}