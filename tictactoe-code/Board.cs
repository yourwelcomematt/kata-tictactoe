using System;
using System.Collections.Generic;
using System.Text;

namespace kata_tictactoe
{
    public class Board
    {
        private List<string> row1;
        private List<string> row2;
        private List<string> row3;

        public void InitialiseBoard()
        {
            row1 = new List<string>() {".", ".", "."};
            row2 = new List<string>() {".", ".", "."};
            row3 = new List<string>() {".", ".", "."};
        }
        
        // To test
        public string GenerateBoard()
        {
            var board = new StringBuilder();
            board.AppendLine($"{row1[0]} {row1[1]} {row1[2]}");
            board.AppendLine($"{row2[0]} {row2[1]} {row2[2]}");
            board.AppendLine($"{row3[0]} {row3[1]} {row3[2]}");
            
            return board.ToString();
        }
        
        // To test
        public void UpdateBoard(string coordinates, string symbol)
        {
            int rowNumber = int.Parse(coordinates.Substring(0, 1));
            int columnNumberIndex = int.Parse(coordinates.Substring(3, 1)) - 1;

            if (rowNumber == 1)
            {
                row1[columnNumberIndex] = symbol;
            }
            else if (rowNumber == 2)
            {
                row2[columnNumberIndex] = symbol;
            }
            else
            {
                row3[columnNumberIndex] = symbol;
            }
        }
    }
}