using LudoGameEngine;
using LudoWebApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace LudoWebApiTests
{
    class GameContainerMock : ILudoGameContainer
    {
        ILudoGame _game;
        public ILudoGame LudoGameMock{
            set
            {
                _game = value;
            }
        }

        public ILudoGame this[int gameId] {
            get
            {
                return _game;
            }
        }

        public void CreateGame(int gameId)
        {
            throw new NotImplementedException();
        }

        public void DeleteGame(int id)
        {
            throw new NotImplementedException();
        }

        public List<int> GetIdsOfAllGames()
        {
            throw new NotImplementedException();
        }
    }
}
