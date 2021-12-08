using System.Collections.Generic;
using kata_tictactoe;
using Xunit;

namespace tictactoe_tests
{
    public class BoardTests
    {
        [Fact]
        public void CanCorrectlyInitialise_Board_AfterConstruction()
        {
            // Arrange
            Board board = new();
            // Act
            string actual = board.GetStringOfBoard();
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
            // Act
            board.UpdateBoard("3, 1", "X");
            List<string> actual = board.Row3;
            List<string> expected = new() {"X", ".", "."};
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CanGet_StringOfBoard_AfterMoveIsMade()
        {
            // Arrange
            Board board = new();
            board.UpdateBoard("3, 1", "X");
            // Act
            string actual = board.GetStringOfBoard();
            string expected = ". . .\n" + 
                              ". . .\n" +
                              "X . .\n";
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}