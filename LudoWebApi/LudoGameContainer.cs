using LudoGameEngine;
using System.Collections.Generic;
using System.Linq;

namespace LudoWebApi
{
    public class LudoGameContainer : ILudoGameContainer
    {
        private Dictionary<int, LudoGame> ludoGames;
        private IDiece diece;

        public LudoGameContainer(IDiece di)
        {
            ludoGames = new Dictionary<int, LudoGame>();
            diece = di;
        }

        public LudoGame GetGame(int id)
        {
            if (!ludoGames.ContainsKey(id))
            {
                ludoGames.Add(id, new LudoGame(diece));
            }

            return ludoGames[id];
        }

        public List<int> GetIdOfAllGames()
        {
            return ludoGames.Select(d => d.Key).ToList();
        }

        public void DeleteGame(int id)
        {
            ludoGames.Remove(id);
        }
    }
}
