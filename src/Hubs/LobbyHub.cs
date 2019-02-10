using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;
using yatzoo.Models;
using yatzoo.Services;

namespace yatzoo.Hubs
{
    public class LobbyHub : Hub
    {
        private readonly ILobbyService _lobbyService;
        private readonly IMessageService _messageService;
        private readonly IPlayerService _playerService;

        public async Task GetPlayers(Guid lobbyId)
        {
            var lobby = await _lobbyService.GetLobbyById(lobbyId);
            await Clients.Group(lobbyId.ToString()).SendAsync("players", lobby.players);
        }
        public LobbyHub(ILobbyService lobbyService, IMessageService messageService, IPlayerService playerService)
        {
            _lobbyService = lobbyService;
            _messageService = messageService;
            _playerService = playerService;
        }
        public async Task CreateLobby(Guid id)
        {
            await Clients.All.SendAsync("lobbyCreated", id, "Lobby created");
        }
        public Task AddToLobby(Guid lobbyId, Guid playerId) => Groups.AddToGroupAsync(groupName: lobbyId.ToString(), connectionId: playerId.ToString());
        public async Task RemoveFromLobby(Guid lobbyId, Guid playerId) => await Groups.RemoveFromGroupAsync(groupName: lobbyId.ToString(), connectionId: playerId.ToString());
    }
}