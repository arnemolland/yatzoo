using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using yatzoo.Models;
using yatzoo.Services;

namespace yatzoo.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class LobbyController : Controller
    {
        private readonly ILobbyService _lobbyService;

        public LobbyController(ILobbyService lobbyService) => _lobbyService = lobbyService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var lobbies = await _lobbyService.GetLobbiesAsync();

            return Ok(lobbies);
        }

        [HttpPost]
        public async void Post([FromBody]Lobby lobby) => await _lobbyService.AddLobbyAsync(lobby);
    }
}