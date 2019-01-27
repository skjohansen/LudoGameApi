using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LudoWebApi.Models
{
    public class GameModel
    {
        public string State { get; set; }
        public int GameId { get; set; }
        public int NumberOfPlayers { get; set; }
        public int CurrentPlayerId { get; set; }
        
    }
}
