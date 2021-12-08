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
    }
}