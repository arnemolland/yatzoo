using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace yatzoo.Hubs {
    public class TestHub : Hub {
        public async Task SendMessage(string name, string message) {
            await Clients.All.SendAsync("broadcastMessage", name, message);
            System.Console.WriteLine($"{name}: {message}");
        }
    }
}