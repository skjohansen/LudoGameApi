using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LudoGameEngine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LudoWebApi.Controllers
{
    [Route("api/ludo")]
    [ApiController]
    public class LudoController : ControllerBase
    {
        private ILudoGameContainer ludoGames;
        private IGameIdGenerator gameIdGenerator;


        public LudoController(ILudoGameContainer lgc, IGameIdGenerator gid)
        {
            ludoGames = lgc;
            gameIdGenerator = gid;
        }

        // GET: api/Ludo
        /// <summary>
        /// Lista av fia spel 
        /// </summary>
        /// <returns>Lista av fia spel </returns>
        [HttpGet]
        public IEnumerable<int> Get()
        {
            return ludoGames.GetIdsOfAllGames().ToArray();
        }


        // POST: api/Ludo
        /// <summary>
        /// Skåpa ett nytt spel
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public int Post()
        {
            var randomId = gameIdGenerator.GenerateGameId();
            ludoGames.GetGame(randomId);
            return randomId;
        }


        // GET: api/Ludo/5
        /// <summary>
        /// Detaljeret information om spelet, som vart alla pjäser finns
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns>Detaljeret information om spelet, som vart alla pjäser finns</returns>
        [HttpGet("{gameId}")]
        public string GetGame(int gameId)
        {
            return "value";
        }

        // PUT: api/Ludo/5
        /// <summary>
        /// Ändra placering på en pjäs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{gameId}")]
        public void PutGame(int gameId, [FromBody] string value)
        {
        }

        // DELETE: api/Ludo/5
        /// <summary>
        /// Ta bort ett spel
        /// </summary>
        /// <param name="gameId"></param>
        [HttpDelete("{gameId}")]
        public void DeleteGame(int gameId)
        {
        }
    }
}
