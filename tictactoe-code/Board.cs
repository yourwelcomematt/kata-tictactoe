using System.Text;

namespace kata_tictactoe
{
    public class Board
    {
        private string row1 { get; set; }
        private string row2 { get; set; }
        private string row3 { get; set; }

        public string PrintBoard()
        {
            var board = new StringBuilder();
            board.AppendLine(row1);
            board.AppendLine(row2);
            board.AppendLine(row3);
            
            return board.ToString();
        }

        public void InitialiseBoard()
        {
            row1 = ". . .";
            row2 = ". . .";
            row3 = ". . .";
        }

        public void UpdateBoard(string coordinates)
        {
            
        }
    }
}