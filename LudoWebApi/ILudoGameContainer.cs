using LudoGameEngine;
using System.Collections.Generic;

namespace LudoWebApi
{
    public interface ILudoGameContainer
    {
        LudoGame GetGame(int id);
        List<int> GetIdOfAllGames();
        void DeleteGame(int id);
    }
}