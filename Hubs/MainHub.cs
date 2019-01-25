using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace yatzoo.Hubs {
    public class MainHub : Hub {
        public async Task CreateLobby(string id) {
            await Clients.All.SendAsync("newLobbyCreated", id, "Lobby created");
        }

        public async Task JoinLobby(string userId, string lobbyId) {
            await Clients.All.SendAsync("joinLobby", userId, lobbyId);
        }
    }
}