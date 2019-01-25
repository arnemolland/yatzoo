using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace yatzoo.Models
{
    public class Lobby
    {
        public List<Player> players { get; set; }
        public DateTime creationTime { get; }

        [Required]
        public string name { get; set; }

        public Guid id { get; set; }

        public Lobby()
        {
            this.id = Guid.NewGuid();
            this.creationTime = DateTime.Now;
        }

        public Lobby(List<Player> players)
        {
            this.creationTime = DateTime.Now;
            this.players = players;
            this.id = Guid.NewGuid();
            this.name = id.ToString();
        }

        public Lobby(string name)
        {
            this.name = name;
            this.creationTime = DateTime.Now;
            this.players = new List<Player>();
            this.id = Guid.NewGuid();
        }
    }
}