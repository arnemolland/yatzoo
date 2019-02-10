using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using yatzoo.Services;

namespace yatzoo.Hubs
{
    public class GameHub : Hub
    {
        private readonly ILobbyService _lobbyService;
        private readonly IMessageService _messageService;
        private readonly IPlayerService _playerService;
        private readonly IGameService _gameService;

        public GameHub(ILobbyService lobbyService, IMessageService messageService, IPlayerService playerService, IGameService gameService)
        {
            _lobbyService = lobbyService;
            _messageService = messageService;
            _playerService = playerService;
            _gameService = gameService;
        }
        public async Task CreateGame(string gameId)
        {
            await Clients.All.SendAsync("gameCreated", gameId, "Game created");
        }

        public async Task RollDies(Guid gameId, string playerId)
        {
            var game = await _gameService.GetGameAsync(gameId);
        }
    }
}