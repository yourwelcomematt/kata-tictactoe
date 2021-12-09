using kata_tictactoe;
using Xunit;

namespace tictactoe_tests
{
    public class GameDialogueTests
    {
        [Fact]
        public void CanGet_WelcomeMessageString_AtStartUp()
        {
            // Arrange
            GameDialogue gameDialogue = new();
            // Act
            string expected = "Welcome to Tic Tac Toe!\n\n" +
                              "Here's the current board:\n\n" +
                              ". . .\n" +
                              ". . .\n" +
                              ". . .\n";
            string actual = gameDialogue.GetWelcomeMessageString();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}