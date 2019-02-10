using System.Collections.Generic;

namespace yatzoo.Models
{

    public class GameState
    {
        Lobby lobby { get; }
        Scoreboard board { get; }

        public GameState()
        {
            lobby = new Lobby();
            board = new Scoreboard();
        }

        public GameState(Lobby lobby)
        {
            this.lobby = lobby;
            board = new Scoreboard();
        }
    }
}