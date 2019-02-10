using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using yatzoo.Models;
using yatzoo.Services;
using Microsoft.AspNetCore.Cors;

namespace yatzoo.Controllers {
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class MessageController : Controller {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService) => _messageService = messageService;

        [HttpGet]
        public async Task<IActionResult> GetAction() {
            return Ok( await _messageService.GetMessagesAsync());
        }

        [HttpGet("{lobbyId}")]
        public async Task<IActionResult> Get(Guid lobbyId) {
            if(lobbyId == Guid.Empty) {
                return NotFound();
            }

            return Ok(await _messageService.GetMessagesInLobbyAsync(lobbyId));
        }

        [HttpPost]
        public async void Post([FromBody] Message message) => await _messageService.AddMessageToLobbyAsync(message.lobbyId, message);


    }
}
