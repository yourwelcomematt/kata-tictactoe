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
            string expected = ". . .\n" + ". . .\n" + ". . .\n";
            // Assert
            Assert.Equal(expected, actual);
        }

        [InlineData("X")]
        [InlineData("O")]
        [Theory]
        public void CanUpdate_Row1_AfterMoveIsMade(string symbol)
        {
            // Arrange
            Board board = new();
            board.InitialiseBoard();
            // Act
            board.UpdateBoard("1, 1", symbol);
            string actual = board.GenerateBoard();
            string expected = $"{symbol} . .\n" + ". . .\n" + ". . .\n";
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [InlineData("X")]
        [InlineData("O")]
        [Theory]
        public void CanUpdate_Row2_AfterMoveIsMade(string symbol)
        {
            // Arrange
            Board board = new();
            board.InitialiseBoard();
            // Act
            board.UpdateBoard("2, 1", symbol);
            string actual = board.GenerateBoard();
            string expected = ". . .\n" + $"{symbol} . .\n" + ". . .\n";
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [InlineData("X")]
        [InlineData("O")]
        [Theory]
        public void CanUpdate_Row3_AfterMoveIsMade(string symbol)
        {
            // Arrange
            Board board = new();
            board.InitialiseBoard();
            // Act
            board.UpdateBoard("3, 1", symbol);
            string actual = board.GenerateBoard();
            string expected = ". . .\n" + ". . .\n" + $"{symbol} . .\n";
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}