using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Yatzoo.Hubs {
    public class LobbyHub : Hub {
        public async Task CreateLobby(string id) {
            await Clients.All.SendAsync("ReceiveMessage", id, "Lobby created");
        }
    }
}