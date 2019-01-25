using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace yatzoo.Hubs
{
    public class LobbyHub : Hub
    {
        public async Task CreateLobby(string id)
        {
            await Clients.All.SendAsync("ReceiveMessage", id, "Lobby created");
        }
        public Task AddToLobby(string lobby, string connectionId) => Groups.AddToGroupAsync(groupName: lobby, connectionId: connectionId);
        public async Task RemoveFromLobby(string lobby, string connectionId) => await Groups.RemoveFromGroupAsync(groupName: lobby, connectionId: connectionId);
    }
}