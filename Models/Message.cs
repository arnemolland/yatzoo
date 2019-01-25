using System;
using System.ComponentModel.DataAnnotations;

namespace yatzoo.Models
{
    public class Message
    {
        public Guid id { get; set; }
        public Guid lobbyId { get; set; }

        [Required]
        public string contents { get; set; }
        [Required]
        public string username { get; set; }
        public DateTimeOffset postedAt { get; set; }
    }
}