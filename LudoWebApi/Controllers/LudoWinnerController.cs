using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LudoWebApi.Controllers
{
    [Route("api/ludo")]
    [ApiController]
    public class LudoWinnerController : ControllerBase
    {
        private ILudoGameContainer ludoGames;

        public LudoWinnerController(ILudoGameContainer lgc)
        {
            ludoGames = lgc;
        }

        // GET: api/ludo/3/winner
        /// <summary>
        /// Name of the winner (If the game is over)
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        [HttpGet("{gameId}/winner")]
        public string Get(int gameId)
        {
            var winner = ludoGames[gameId].GetWinner();
            return winner == null ? "N/A" : winner.Name;
        }
    }
}
