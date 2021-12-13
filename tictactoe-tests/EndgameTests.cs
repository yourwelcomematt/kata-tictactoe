using System.Collections.Generic;
using System.Text;
using kata_tictactoe;
using Xunit;

namespace tictactoe_tests
{
    public class EndgameTests
    {
        [Fact]
        public void CheckIfThereAreMovesLeft_ReturnsFalse_IfThereAreNoMovesLeft()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {"X", "O", "X"};
            board.Row2 = new List<string>() {"X", "O", "O"};
            board.Row3 = new List<string>() {"O", "X", "X"};
            // Act
            bool expected = false;
            bool actual = endgame.CheckIfThereAreMovesLeft(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfThereAreMovesLeft_ReturnsTrue_AtTheStartOfTheGame()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {".", ".", "."};
            board.Row2 = new List<string>() {".", ".", "."};
            board.Row3 = new List<string>() {".", ".", "."};
            // Act
            bool expected = true;
            bool actual = endgame.CheckIfThereAreMovesLeft(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfThereAreMovesLeft_ReturnsTrue_IfThereAreMovesLeft()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {"X", ".", "."};
            board.Row2 = new List<string>() {".", "X", "."};
            board.Row3 = new List<string>() {".", "O", "O"};
            // Act
            bool expected = true;
            bool actual = endgame.CheckIfThereAreMovesLeft(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfAPlayerHasWon_ReturnsTrue_IfPlayer1HasWonAColumn()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {"X", ".", "."};
            board.Row2 = new List<string>() {"X", ".", "O"};
            board.Row3 = new List<string>() {"X", ".", "O"};
            // Act
            bool expected = true;
            bool actual = endgame.CheckIfAPlayerHasWon(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfAPlayerHasWon_ReturnsTrue_IfPlayer1HasWonARow()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {".", ".", "O"};
            board.Row2 = new List<string>() {"X", "X", "X"};
            board.Row3 = new List<string>() {".", ".", "O"};
            // Act
            bool expected = true;
            bool actual = endgame.CheckIfAPlayerHasWon(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfAPlayerHasWon_ReturnsTrue_IfPlayer2HasWonARow()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {".", ".", "."};
            board.Row2 = new List<string>() {".", "X", "X"};
            board.Row3 = new List<string>() {"O", "O", "O"};
            // Act
            bool expected = true;
            bool actual = endgame.CheckIfAPlayerHasWon(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfAPlayerHasWon_ReturnsTrue_IfPlayer1HasWonADiagonal()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {"X", ".", "O"};
            board.Row2 = new List<string>() {".", "X", "."};
            board.Row3 = new List<string>() {".", "O", "X"};
            // Act
            bool expected = true;
            bool actual = endgame.CheckIfAPlayerHasWon(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfAPlayerHasWon_ReturnsTrue_IfPlayer2HasWonADiagonal()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {".", ".", "O"};
            board.Row2 = new List<string>() {".", "O", "X"};
            board.Row3 = new List<string>() {"O", ".", "X"};
            // Act
            bool expected = true;
            bool actual = endgame.CheckIfAPlayerHasWon(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfAPlayerHasWon_ReturnsFalse_IfNoOneHasWonYet()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {".", ".", "."};
            board.Row2 = new List<string>() {"X", ".", "O"};
            board.Row3 = new List<string>() {"X", ".", "O"};
            // Act
            bool expected = false;
            bool actual = endgame.CheckIfAPlayerHasWon(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CheckIfAPlayerHasWon_ReturnsFalse_AtTheStartOfTheGame()
        {
            // Arrange
            Endgame endgame = new();
            Board board = new();
            board.Row1 = new List<string>() {".", ".", "."};
            board.Row2 = new List<string>() {".", ".", "."};
            board.Row3 = new List<string>() {".", ".", "."};
            // Act
            bool expected = false;
            bool actual = endgame.CheckIfAPlayerHasWon(board.Row1, board.Row2, board.Row3);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}