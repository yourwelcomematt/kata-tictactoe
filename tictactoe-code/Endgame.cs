using System.Collections.Generic;

namespace kata_tictactoe
{
    public class Endgame
    {
        public bool CheckIfThereAreMovesLeft(List<string> row1, List<string> row2, List<string> row3)
        {
            return row1[0].Equals(".") || row1[1].Equals(".") || row1[2].Equals(".") || row2[0].Equals(".") ||
                   row2[1].Equals(".") || row2[2].Equals(".") || row3[0].Equals(".") || row3[1].Equals(".") ||
                   row3[2].Equals(".");
        }

        public bool CheckIfAPlayerHasWon(List<string> row1, List<string> row2, List<string> row3)
        {
            bool column1Win = row1[0].Equals(row2[0]) && row2[0].Equals(row3[0]) && !row1[0].Equals(".");
            bool column2Win = row1[1].Equals(row2[1]) && row2[1].Equals(row3[1]) && !row1[1].Equals(".");
            bool column3Win = row1[2].Equals(row2[2]) && row2[2].Equals(row3[2]) && !row1[2].Equals(".");
            bool row1Win = row1[0].Equals(row1[1]) && row1[1].Equals(row1[2]) && !row1[0].Equals(".");
            bool row2Win = row2[0].Equals(row2[1]) && row2[1].Equals(row2[2]) && !row2[0].Equals(".");
            bool row3Win = row3[0].Equals(row3[1]) && row3[1].Equals(row3[2]) && !row3[0].Equals(".");
            bool leftDiagonalWin = row1[0].Equals(row2[1]) && row2[1].Equals(row3[2]) && !row1[0].Equals(".");
            bool rightDiagonalWin = row1[2].Equals(row2[1]) && row2[1].Equals(row3[0]) && !row1[2].Equals(".");

            return column1Win || column2Win || column3Win || row1Win || row2Win || row3Win || leftDiagonalWin || rightDiagonalWin;
        }
    }
}