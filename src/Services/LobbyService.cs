using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using yatzoo.Models;
using yatzoo.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace yatzoo.Services
{
    public class LobbyService : ILobbyService
    {
        private readonly ApplicationDbContext _context;

        public LobbyService(ApplicationDbContext context) => _context = context;

        public async Task<List<Lobby>> GetLobbiesAsync()
        {
            return await _context.lobbies.ToListAsync<Lobby>();
        }

        public async Task<Lobby> GetLobbyById(Guid id) {
            return await _context.lobbies.FindAsync(id);
        }

        public async Task<bool> AddLobbyAsync(Lobby lobby)
        {
            lobby.id = Guid.NewGuid();
            _context.lobbies.Add(lobby);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}