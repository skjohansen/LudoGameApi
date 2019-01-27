using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LudoGameEngine;
using LudoWebApi.Models;
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
        public IEnumerable<LudoPlayer> Get(int gameId)
        {
            return ludoGames[gameId].GetPlayers().Select(p => 
                new LudoPlayer() {
                    Color = p.PlayerColor.ToString(),
                    Id = p.PlayerId,
                    Name = p.Name }
                );
        }


        // POST: api/ludo/3/players
        /// <summary>
        /// Lägg till en ny spelere till spelet
        /// </summary>
        /// <param name="value"></param>
        [HttpPost("{gameId}/players")]
        public ActionResult Post(int gameId, [FromBody] LudoPlayer player)
        {
            PlayerColor playerColor = ParseColor(player.Color);
            try
            {
                ludoGames[gameId].AddPlayer(player.Name, playerColor);
                return Ok();
            }
            catch
            {
                return BadRequest("Unable to add player");
            }
        }

        private PlayerColor ParseColor(string color) {
            switch (color.Trim().ToLower())
            {
                case "red": return PlayerColor.Red;
                case "green": return PlayerColor.Green;
                case "blue": return PlayerColor.Blue;
                case "yellow": return PlayerColor.Yellow;
            }
            throw new Exception($"Color {color} is unknown, the suported colors are: red, green, blue and yellow");
        }

        // GET: api/ludo/3/players/4
        /// <summary>
        /// Detajeret information om speleren
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{gameId}/players/{playerId}")]
        public LudoPlayer Get(int gameId, int playerId)
        {
            var player = ludoGames[gameId].GetPlayers().First(p =>  p.PlayerId == playerId);
            return new LudoPlayer()
            {
                Color = player.PlayerColor.ToString(),
                Id = player.PlayerId,
                Name = player.Name
            };
        }

        // PUT: api/ludo/3/players/4
        /// <summary>
        /// Ändra namn på speleren
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{gameId}/players/{playerId}")]
        public void Put(int gameId, int playerId, [FromBody] LudoPlayer value)
        {
            var player = ludoGames[gameId].GetPlayers().First(p => p.PlayerId == playerId);
            player.Name = value.Name;
        }
    }
}
