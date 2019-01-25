using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace yatzoo.Hubs {
    public class GameHub : Hub {
        public async Task CreateGame(string gameId) {
            await Clients.All.SendAsync("gameCreated", gameId, "Game created");
        }
    }
}