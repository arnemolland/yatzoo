using System.Collections.Generic;
using System;

namespace yatzoo.Models
{
    class Lobby
    {
        List<Player> players { get; set; }
        DateTime creationTime { get; }

        public Lobby() => creationTime = DateTime.Now;

        public Lobby(List<Player> players)
        {
            this.creationTime = DateTime.Now;
            this.players = players;
        }
    }
}