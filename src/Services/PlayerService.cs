using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using yatzoo.Models;
using yatzoo.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace yatzoo.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context) => _context = context;

        public async Task<List<Player>> GetPlayersAsync()
        {
            return await _context.players.ToListAsync<Player>();
        }

        public async Task<Player> GetPlayerByIdAsync(Guid playerId)
        {
            List<Player> players = await _context.players.ToListAsync<Player>();
            return players.Find(x => x.id == playerId);
        }

        public async Task<bool> AddPlayerAsync(Player player)
        {
            player.id = Guid.NewGuid();
            _context.players.Add(player);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}