using System;
using System.Collections.Generic;
using System.Text;

namespace kata_tictactoe
{
    public class Board
    {
        private List<string> row1 { get; set; }
        private List<string> row2 { get; set; }
        private List<string> row3 { get; set; }

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
            int xCoordinate = int.Parse(coordinates.Substring(0, 1));
            int yCoordinate = int.Parse(coordinates.Substring(3, 1));
            Console.WriteLine($"X coordinate is {xCoordinate} and y coordinate is {yCoordinate}");

            if (xCoordinate == 1)
            {
                row1[yCoordinate - 1] = symbol;
            }
            else if (xCoordinate == 2)
            {
                row2[yCoordinate - 1] = symbol;
            }
            else
            {
                row3[yCoordinate - 1] = symbol;
            }
        }
    }
}