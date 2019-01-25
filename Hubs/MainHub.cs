using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;
using yatzoo.Models;
using yatzoo.Services;

namespace yatzoo.Hubs {
    public class MainHub : Hub {

        private readonly ILobbyService _lobbyService;
        private readonly IMessageService _messageService;

        public int usersOnline;

        public MainHub(ILobbyService lobbyService, IMessageService messageService) {
            _lobbyService = lobbyService;
            _messageService = messageService;
        }
        public async Task AddLobby(string name) {
            Lobby lobby = new Lobby() {
                name = name
            };

            await _lobbyService.AddLobbyAsync(lobby);
            await Clients.All.SendAsync("newLobbyCreated", name, lobby.id);
        }

        public async Task JoinLobby(string userId, string lobbyId) {
            await Clients.All.SendAsync("joinLobby", userId, lobbyId);
        }

        public override async Task OnConnectedAsync() {
            usersOnline++;
            await Groups.AddToGroupAsync(Context.ConnectionId, "AllUsers");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception ex) {
            usersOnline--;
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "AllUsers");
            await base.OnDisconnectedAsync(ex);
        }
    }
}