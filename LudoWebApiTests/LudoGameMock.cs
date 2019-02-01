using LudoGameEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace LudoWebApiTests
{
    class LudoGameMock : ILudoGame
    {
        public bool ThrowExceptionWhenAddedPlayer { get; set; }

        public Player AddPlayer(string name, PlayerColor color)
        {
            if (ThrowExceptionWhenAddedPlayer)
            {
                throw new Exception();
            }

            return null;
        }

        public void EndTurn(Player player)
        {
            throw new NotImplementedException();
        }

        public Piece[] GetAllPiecesInGame()
        {
            throw new NotImplementedException();
        }

        public Player GetCurrentPlayer()
        {
            throw new NotImplementedException();
        }

        public GameState GetGameState()
        {
            throw new NotImplementedException();
        }

        public Player[] GetPlayers()
        {
            throw new NotImplementedException();
        }

        public Player GetWinner()
        {
            throw new NotImplementedException();
        }

        public void MovePiece(Player player, int pieceId, int numberOfFields)
        {
            throw new NotImplementedException();
        }

        public int RollDiece()
        {
            throw new NotImplementedException();
        }

        public bool StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
