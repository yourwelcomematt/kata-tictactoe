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

        public void UpdateBoard(string coordinates, string player)
        {
            switch (coordinates)
            {
                case "1, 1" when player.Equals("Player 1"):
                    row1 = "X . .";
                    break;
                case "1, 1" when player.Equals("Player 2"):
                    row1 = "O . .";
                    break;
                case "1, 2" when player.Equals("Player 1"):
                    row1 = ". X .";
                    break;
                case "1, 2" when player.Equals("Player 2"):
                    row1 = ". O .";
                    break;
                case "1, 3" when player.Equals("Player 1"):
                    row1 = ". . X";
                    break;
                case "1, 3" when player.Equals("Player 2"):
                    row1 = ". . O";
                    break;
                case "2, 1" when player.Equals("Player 1"):
                    row2 = "X . .";
                    break;
                case "2, 1" when player.Equals("Player 2"):
                    row2 = "O . .";
                    break;
                case "2, 2" when player.Equals("Player 1"):
                    row2 = ". X .";
                    break;
                case "2, 2" when player.Equals("Player 2"):
                    row2 = ". O .";
                    break;
                case "2, 3" when player.Equals("Player 1"):
                    row2 = ". . X";
                    break;
                case "2, 3" when player.Equals("Player 2"):
                    row2 = ". . O";
                    break;
                case "3, 1" when player.Equals("Player 1"):
                    row3 = "X . .";
                    break;
                case "3, 1" when player.Equals("Player 2"):
                    row3 = "O . .";
                    break;
                case "3, 2" when player.Equals("Player 1"):
                    row3 = ". X .";
                    break;
                case "3, 2" when player.Equals("Player 2"):
                    row3 = ". O .";
                    break;
                case "3, 3" when player.Equals("Player 1"):
                    row3 = ". . X";
                    break;
                case "3, 3" when player.Equals("Player 2"):
                    row3 = ". . O";
                    break;
            }
        }
    }
}