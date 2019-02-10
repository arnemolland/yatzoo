using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using yatzoo.Models;

namespace yatzoo.Services
{
    public interface IPlayerService
    {
        Task<List<Player>> GetPlayersAsync();
        Task<Player> GetPlayerByIdAsync(Guid playerId);
        Task<bool> AddPlayerAsync(Player newPlayer);
    }
}