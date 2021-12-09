using kata_tictactoe;
using Xunit;

namespace tictactoe_tests
{
    public class GameDialogueTests
    {
        [Fact]
        public void CanGet_WelcomeMessageString()
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

        [Fact]
        public void CanGet_UserInputPromptString_ForPlayer1()
        {
            // Arrange
            GameDialogue gameDialogue = new();
            Player player1 = new("Player 1", "X");
            // Act
            string expected = "Player 1 enter a coord x,y to place your X or enter 'q' to give up: ";
            string actual = gameDialogue.GetUserInputPromptString(player1);
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CanGet_UserInputPromptString_ForPlayer2()
        {
            // Arrange
            GameDialogue gameDialogue = new();
            Player player2 = new("Player 2", "O");
            // Act
            string expected = "Player 2 enter a coord x,y to place your O or enter 'q' to give up: ";
            string actual = gameDialogue.GetUserInputPromptString(player2);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}