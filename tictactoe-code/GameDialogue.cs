using System.Text;

namespace kata_tictactoe
{
    public class GameDialogue
    {
        public string GetWelcomeMessageString()
        {
            Board board = new();
            
            return "Welcome to Tic Tac Toe!\n\n" + "Here's the current board:\n\n" + board.GetStringOfBoard();
        }

        public string GetUserInputPromptString(Player player)
        {
            return $"{player.Name} enter a coord x,y to place your {player.Symbol} or enter 'q' to give up: ";
        }
    }
}