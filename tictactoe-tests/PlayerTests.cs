using kata_tictactoe;
using Xunit;

namespace tictactoe_tests
{
    public class PlayerTests
    {
        [Fact]
        public void CanRetrieve_XSymbol_FromPlayer()
        {
            // Arrange
            Player player = new("X");
            // Act
            string expected = "X";
            string actual = player.Symbol;
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CanRetrieve_OSymbol_FromPlayer()
        {
            // Arrange
            Player player = new("O");
            // Act
            string expected = "O";
            string actual = player.Symbol;
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CanUpdate_Board_UsingPlayerSymbol()
        {
            // Arrange
            Board board = new();
            Player player = new("X");
            // Act
            board.UpdateBoard("1, 1", player.Symbol);
            string expected = "X . .\n" +
                              ". . .\n" +
                              ". . .\n";
            string actual = board.GetStringOfBoard();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}