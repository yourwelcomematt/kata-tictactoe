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
    }
}