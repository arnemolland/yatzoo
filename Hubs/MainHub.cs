using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;
using yatzoo.Models;
using yatzoo.Services;

namespace yatzoo.Hubs
{
    public class MainHub : Hub
    {
        private readonly IPlayerService _playerService;
        private readonly ILobbyService _lobbyService;
        private readonly IMessageService _messageService;

        public int usersOnline;

        public async Task GetUserCount() {
            await Clients.All.SendAsync("playerCount", usersOnline);
        }

        public async Task GetUserId() {
            await Clients.User(Context.ConnectionId.ToString()).SendAsync("userId", Context.ConnectionId.ToString());
        }

        public async Task GetLobbies() {
            await Clients.All.SendAsync("lobbies", _lobbyService.GetLobbiesAsync());
        }

        public async Task SendMessage(string message, Guid playerId) {
            var player = await _playerService.GetPlayerByIdAsync(playerId);
            await Clients.All.SendAsync("broadcastMessage", message, player);
        }

        public MainHub(ILobbyService lobbyService, IMessageService messageService, IPlayerService playerService)
        {
            _lobbyService = lobbyService;
            _messageService = messageService;
            _playerService = playerService;
        }
        public async Task AddLobby(string name)
        {
            Lobby lobby = new Lobby()
            {
                name = name
            };

            await _lobbyService.AddLobbyAsync(lobby);
            await Clients.All.SendAsync("newLobbyCreated", name, lobby.id);
        }

        public async Task JoinLobby(Guid userId, Guid lobbyId)
        {
            await Clients.All.SendAsync("joinLobby", userId, lobbyId);
            await Groups.AddToGroupAsync(connectionId: userId.ToString(), groupName: lobbyId.ToString());
        }

        public override async Task OnConnectedAsync()
        {
            usersOnline++;
            await Groups.AddToGroupAsync(Context.ConnectionId, "GlobalUsers");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            usersOnline--;
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "GlobalUsers");
            await base.OnDisconnectedAsync(ex);
        }
    }
}