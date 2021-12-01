using System.Text;

namespace kata_tictactoe
{
    public class Board
    {
        private string row1 = ". . .";
        private string row2 = ". . .";
        private string row3 = ". . .";

        public string printBoard()
        {
            var board = new StringBuilder();
            board.AppendLine(row1);
            board.AppendLine(row2);
            board.AppendLine(row3);
            
            return board.ToString();
        }
    }
}