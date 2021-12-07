using System.Collections.Generic;
using kata_tictactoe;
using Xunit;

namespace tictactoe_tests
{
    public class BoardTests
    {
        [Fact]
        public void CanGenerate_Board_AfterInitialising()
        {
            // Arrange
            Board board = new();
            // Act
            board.InitialiseBoard();
            string actual = board.GenerateBoard();
            string expected = ". . .\n" + 
                              ". . .\n" +
                              ". . .\n";
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CanUpdate_Row1_AfterMoveIsMade()
        {
            // Arrange
            Board board = new();
            board.InitialiseBoard();
            // Act
            board.UpdateBoard("1, 1", "X");
            List<string> actual = board.Row1;
            List<string> expected = new() {"X", ".", "."};
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CanUpdate_Row2_AfterMoveIsMade()
        {
            // Arrange
            Board board = new();
            board.InitialiseBoard();
            // Act
            board.UpdateBoard("2, 1", "X");
            List<string> actual = board.Row2;
            List<string> expected = new() {"X", ".", "."};
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CanUpdate_Row3_AfterMoveIsMade()
        {
            // Arrange
            Board board = new();
            board.InitialiseBoard();
            // Act
            board.UpdateBoard("3, 1", "X");
            List<string> actual = board.Row3;
            List<string> expected = new() {"X", ".", "."};
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}