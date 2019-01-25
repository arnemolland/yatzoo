using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using yatzoo.Models;

namespace yatzoo.Services
{
    public interface IGameService
    {
        Task<Game> GetGameAsync(Guid gameId);
        Task<bool> AddGameAsync(Game game);
        Task<bool> RemoveGameAsync(Game game);
    }
}