using System;
using kata_tictactoe;
using Xunit;

namespace tictactoe_tests
{
    public class GameIoTests
    {
        [Fact]
        public void CanGet_WelcomeMessageString()
        {
            // Arrange
            GameIo gameIo = new();
            // Act
            string expected = "Welcome to Tic Tac Toe!\n\n" +
                              "Here's the current board:\n\n" +
                              ". . .\n" +
                              ". . .\n" +
                              ". . .\n";
            string actual = gameIo.GetWelcomeMessageString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanGet_UserInputPromptString_ForPlayer1()
        {
            // Arrange
            GameIo gameIo = new();
            Player player1 = new("Player 1", "X");
            // Act
            string expected = "Player 1 enter a coord x,y to place your X or enter 'q' to give up: ";
            string actual = gameIo.GetUserInputPromptString(player1);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CanGet_UserInputPromptString_ForPlayer2()
        {
            // Arrange
            GameIo gameIo = new();
            Player player2 = new("Player 2", "O");
            // Act
            string expected = "Player 2 enter a coord x,y to place your O or enter 'q' to give up: ";
            string actual = gameIo.GetUserInputPromptString(player2);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,1")]
        [InlineData("1,2")]
        [InlineData("1,3")]
        [InlineData("2,1")]
        [InlineData("2,2")]
        [InlineData("2,3")]
        [InlineData("3,1")]
        [InlineData("3,2")]
        [InlineData("3,3")]
        public void ValidateUserInput_ReturnsTrue_IfInputIsValid(string userInput)
        {
            // Arrange
            GameIo gameIo = new();
            // Act
            bool expected = true;
            bool actual = gameIo.ValidateUserInput(userInput);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("   ")]
        [InlineData("a")]
        [InlineData("abc")]
        [InlineData("1")]
        [InlineData("1 ")]
        [InlineData("1, 1")]
        [InlineData("$#@")]
        [InlineData("1#@")]
        [InlineData("#@1")]
        [InlineData("0,0")]
        [InlineData("4,4")]
        [InlineData("1,4")]
        [InlineData("1,0")]
        [InlineData("4,1")]
        [InlineData("0,1")]
        [InlineData("0,4")]
        [InlineData("4,0")]
        [InlineData("3.1")]
        [InlineData("3 1")]
        [InlineData("3a1")]
        [InlineData("3$1")]
        public void ValidateUserInput_ReturnsFalse_IfInputIsInvalid(string userInput)
        {
            // Arrange
            GameIo gameIo = new();
            // Act
            bool expected = false;
            bool actual = gameIo.ValidateUserInput(userInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("q")]
        [InlineData("Q")]
        public void CheckIfQuitting_ReturnsTrue_AfterEnteringQ(string userInput)
        {
            // Arrange
            GameIo gameIo = new();
            // Act
            bool expected = true;
            bool actual = gameIo.CheckIfQuitting(userInput);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData("asd")]
        [InlineData("1,1")]
        public void CheckIfQuitting_ReturnsFalse_AfterNotEnteringQ(string userInput)
        {
            // Arrange
            GameIo gameIo = new();
            // Act
            bool expected = false;
            bool actual = gameIo.CheckIfQuitting(userInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfPositionIsAlreadyFilled_ReturnsTrue_IfChosenPositionIsAlreadyFilled()
        {
            // Arrange
            GameIo gameIo = new();
            Board board = new();
            board.Row1[0] = "X";
            // Act
            bool expected = true;
            bool actual = gameIo.CheckIfPositionIsAlreadyFilled("1,1", board);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfPositionIsAlreadyFilled_ReturnsFalse_IfChosenPositionIsNotAlreadyFilled()
        {
            // Arrange
            GameIo gameIo = new();
            Board board = new();
            // Act
            bool expected = false;
            bool actual = gameIo.CheckIfPositionIsAlreadyFilled("1,1", board);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}