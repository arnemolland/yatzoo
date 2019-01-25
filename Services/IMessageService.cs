using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using yatzoo.Models;

namespace yatzoo.Services {
    public interface IMessageService {
        Task<List<Message>> GetMessagesAsync();
        Task<List<Message>> GetMessagesInLobbyAsync(Guid lobbyId);
        Task<bool> AddMessageToLobbyAsync(Guid lobbyId, Message message);
    }
}