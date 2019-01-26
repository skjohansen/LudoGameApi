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
    public class LudoPlayersController : ControllerBase
    {
        private ILudoGameContainer ludoGames;

        public LudoPlayersController(ILudoGameContainer lgc)
        {
            ludoGames = lgc;
        }

        // GET: api/ludo/3/players
        /// <summary>
        /// List med alla spelera i spelet
        /// </summary>
        /// <returns></returns>
        [HttpGet("{gameId}/players")]
        public IEnumerable<string> Get(int gameId)
        {
            return new string[] { "value1", "value2" };
        }


        // POST: api/ludo/3/players
        /// <summary>
        /// Lägg till en ny spelere till spelet
        /// </summary>
        /// <param name="value"></param>
        [HttpPost("{gameId}/players")]
        public void Post(int gameId, [FromBody] string value)
        {
        }


        // GET: api/ludo/3/players/4
        /// <summary>
        /// Detajeret information om speleren
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{gameId}/players/{playerId}")]
        public string Get(int gameId, int playerId)
        {
            return "value";
        }

        // PUT: api/ludo/3/players/4
        /// <summary>
        /// Ändra namn eller färg på speleren
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{gameId}/players/{playerId}")]
        public void Put(int gameId, int playerId, [FromBody] string value)
        {
        }

        // DELETE: api/ludo/3/players/4
        /// <summary>
        /// Ta bort speleren
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{gameId}/players/{playerId}")]
        public void Delete(int gameId, int playerId)
        {
        }
    }
}
