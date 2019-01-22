using System.Collections.Generic;

namespace Yatzoo
{

    class GameState<T>
    {
        Lobby lobby { get; }
        Roller<T> roller { get; }
        Scoreboard board { get; }

        public GameState()
        {
            lobby = new Lobby();
            roller = new Roller<T>();
            board = new Scoreboard();
        }

        public GameState(Lobby lobby)
        {
            this.lobby = lobby;
            roller = new Roller<T>();
            board = new Scoreboard();
        }
    }
}