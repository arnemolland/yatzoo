using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using yatzoo.Models;
using yatzoo.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace yatzoo.Services
{
    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext _context;

        public MessageService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Message>> GetMessagesAsync()
        {
            return await _context.messages.ToListAsync<Message>();
        }

        public async Task<List<Message>> GetMessagesInLobbyAsync(Guid lobbyId)
        {
            return (await _context.messages
                                       .Where(m => m.lobbyId == lobbyId)
                                                .ToListAsync<Message>());
        }

        public async Task<bool> AddMessageToLobbyAsync(Guid lobbyId, Message message)
        {
            message.id = Guid.NewGuid();
            message.lobbyId = lobbyId;
            message.postedAt = DateTime.Now;

            _context.messages.Add(message);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}