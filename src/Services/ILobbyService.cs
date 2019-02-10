using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using yatzoo.Models;

namespace yatzoo.Services
{
    public interface ILobbyService
    {
        Task<List<Lobby>> GetLobbiesAsync();
        Task<Lobby> GetLobbyById(Guid id);
        Task<bool> AddLobbyAsync(Lobby newLobby);
    }
}