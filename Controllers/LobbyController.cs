using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using yatzoo.Models;

namespace yatzoo.Controllers
{

    public class LobbyController : Controller
    {

        [Route("api/[controller]")]
        class GameLobby
        {
            Lobby currentLobby { get; set; }
        }
    }
}