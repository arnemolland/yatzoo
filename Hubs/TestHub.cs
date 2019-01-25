using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;
using yatzoo.Models;
using yatzoo.Services;

namespace yatzoo.Hubs
{
    public class TestHub : Hub
    {


        private readonly ILobbyService _lobbyService;
        private readonly IMessageService _messageService;
        private readonly IPlayerService _playerService;

        public TestHub(ILobbyService lobbyService, IMessageService messageService, IPlayerService playerService)
        {
            _lobbyService = lobbyService;
            _messageService = messageService;
            _playerService = playerService;
        }
        public async Task SendMessage(Guid playerId, string message, Guid lobbyId)
        {
            Message m = new Message()
            {
                lobbyId = lobbyId,
                contents = message,
                user = await _playerService.GetPlayerByIdAsync(playerId),
            };
            await _messageService.AddMessageToLobbyAsync(lobbyId, m);
            await Clients.All.SendAsync("broadcastMessage", m.user.name, message, m.id, m.postedAt);
        }
    }
}