using LudoGameEngine;
using System.Collections.Generic;

namespace LudoWebApi
{
    public interface ILudoGameContainer
    {
        ILudoGame this[int gameId]
        {
            get;
        }

        List<int> GetIdsOfAllGames();
        void DeleteGame(int id);
        void CreateGame(int gameId);
    }
}