using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using yatzoo.Models;
using yatzoo.Services;

namespace yatzoo.Hubs
{
    public class LobbyHub : Hub
    {
        private readonly ILobbyService _lobbyService;
        private readonly IMessageService _messageService;
        private readonly IPlayerService _playerService;

        public LobbyHub(ILobbyService lobbyService, IMessageService messageService, IPlayerService playerService)
        {
            _lobbyService = lobbyService;
            _messageService = messageService;
            _playerService = playerService;
        }
        public async Task CreateLobby(string id)
        {
            await Clients.All.SendAsync("ReceiveMessage", id, "Lobby created");
        }
        public Task AddToLobby(string lobby, string connectionId) => Groups.AddToGroupAsync(groupName: lobby, connectionId: connectionId);
        public async Task RemoveFromLobby(string lobby, string connectionId) => await Groups.RemoveFromGroupAsync(groupName: lobby, connectionId: connectionId);
    }
}