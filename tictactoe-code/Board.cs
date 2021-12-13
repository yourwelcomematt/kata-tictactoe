using System.Collections.Generic;
using System.Text;

namespace kata_tictactoe
{
    public class Board
    {
        public List<string> Row1 { get; }
        public List<string> Row2 { get; }
        public List<string> Row3 { get; }

        public Board()
        {
            Row1 = new List<string>() {".", ".", "."};
            Row2 = new List<string>() {".", ".", "."};
            Row3 = new List<string>() {".", ".", "."};
        }
        
        public string GetStringOfBoard()
        {
            var board = new StringBuilder();
            board.AppendLine($"{Row1[0]} {Row1[1]} {Row1[2]}");
            board.AppendLine($"{Row2[0]} {Row2[1]} {Row2[2]}");
            board.AppendLine($"{Row3[0]} {Row3[1]} {Row3[2]}");
            
            return board.ToString();
        }
        
        public void UpdateBoard(string coordinates, string symbol)
        {
            int rowNumber = int.Parse(coordinates.Substring(0, 1));
            int columnNumberIndex = int.Parse(coordinates.Substring(2, 1)) - 1;

            if (rowNumber == 1)
            {
                Row1[columnNumberIndex] = symbol;
            }
            else if (rowNumber == 2)
            {
                Row2[columnNumberIndex] = symbol;
            }
            else
            {
                Row3[columnNumberIndex] = symbol;
            }
        }
    }
}