using LudoGameEngine;
using System.Collections.Generic;
using System.Linq;

namespace LudoWebApi
{
    public class LudoGameContainer : ILudoGameContainer
    {
        private Dictionary<int, ILudoGame> ludoGames;
        private IDiece diece;

        public LudoGameContainer(IDiece di)
        {
            ludoGames = new Dictionary<int, ILudoGame>();
            diece = di;
        }

        public ILudoGame this[int gameId] {
            get
            {
                if (!ludoGames.ContainsKey(gameId))
                {
                    ludoGames.Add(gameId, new LudoGame(diece));
                }

                return ludoGames[gameId];
            }
        }

        public List<int> GetIdsOfAllGames()
        {
            return ludoGames.Select(d => d.Key).ToList();
        }

        public void DeleteGame(int id)
        {
            ludoGames.Remove(id);
        }
    }
}
