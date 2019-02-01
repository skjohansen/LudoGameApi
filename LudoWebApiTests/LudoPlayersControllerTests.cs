using LudoGameEngine;
using LudoWebApi.Controllers;
using LudoWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace LudoWebApiTests
{
    public class LudoPlayersControllerTests
    {
        [Theory]
        [InlineData("red")]
        [InlineData("green")]
        [InlineData("yellow")]
        [InlineData("blue")]
        public void Post_AddPlayerOfLegalColorToAnEmptyGame_HttpOkResult(string playerColor)
        {
            // Arrange
            var gameContainerMock = new GameContainerMock();
            gameContainerMock.LudoGameMock = new LudoGameMock();
            var sut = new LudoPlayersController(gameContainerMock);

            // Act
            var result = sut.Post(0,new LudoPlayer() { Name = "player1", Color = "red"});

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void Post_AddAnIlligalPlayerToGame_HttpBadResult()
        {
            // Arrange
            var gameContainerMock = new GameContainerMock();
            gameContainerMock.LudoGameMock = new LudoGameMock() { ThrowExceptionWhenAddedPlayer = true };
            var sut = new LudoPlayersController(gameContainerMock);

            // Act
            var result = sut.Post(0, new LudoPlayer() { Name = "player1", Color = "red" });

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void Post_AddAPlayerWithUnknownColor_Exception()
        {
            // Arrange
            var gameContainerMock = new GameContainerMock();
            gameContainerMock.LudoGameMock = new LudoGameMock() { ThrowExceptionWhenAddedPlayer = true };
            var sut = new LudoPlayersController(gameContainerMock);

            // Assert
            Assert.Throws<Exception>(() => sut.Post(0, new LudoPlayer() { Name = "player1", Color = "orange" }));
        }
    }
}
