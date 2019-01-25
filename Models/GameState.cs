using System.Collections.Generic;

namespace yatzoo.Models
{

    class GameState<T>
    {
        Lobby lobby { get; }
        Roller<T> roller { get; }
        Scoreboard board { get; }
        Game game { get; }

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

        public GameState(Game game)
        {
            this.game = game;
            roller = new Roller<T>();
            board = new Scoreboard();
            lobby = new Lobby();
        }

        public GameState(Game game, Lobby lobby)
        {
            this.game = game;
            this.lobby = lobby;
        }
    }
}