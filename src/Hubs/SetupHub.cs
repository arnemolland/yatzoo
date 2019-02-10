using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using yatzoo.Services;
using yatzoo.Models;

namespace yatzoo.Hubs
{
    public class SetupHub : Hub
    {
        private readonly IPlayerService _playerService;

        public SetupHub(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task RegisterPlayer(string playerName)
        {
            var player = new Player(playerName);
            await _playerService.AddPlayerAsync(player);
            await Clients.All.SendAsync("registerPlayer", player.id);
        }
    }
}