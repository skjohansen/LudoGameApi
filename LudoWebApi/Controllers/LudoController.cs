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
    public class LudoController : ControllerBase
    {
        
        // GET: api/Ludo
        /// <summary>
        /// Lista av fia spel 
        /// </summary>
        /// <returns>Lista av fia spel </returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // POST: api/Ludo
        /// <summary>
        /// Skåpa ett nytt spel
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
