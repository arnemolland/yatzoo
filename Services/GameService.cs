using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using yatzoo.Models;
using yatzoo.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace yatzoo.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;

        public GameService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Game> GetGameAsync(Guid gameId)
        {
            List<Game> result = await _context.games.ToListAsync<Game>();
            return result.Find(x => x.id == gameId);
        }

        public async Task<bool> AddGameAsync(Game game)
        {
            game.id = Guid.NewGuid();
            _context.games.Add(game);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveGameAsync(Game game)
        {
            _context.games.Remove(game);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}