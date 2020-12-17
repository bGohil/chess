using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGame
{
    public class Bishop
    {
        //validation required to check whether it moved to correct direction or not
        public bool CheckIsValidMove(int numberOftep,Directions directions)
        {
            bool IsValidMove = true;
            if (directions != Directions.ForwardLeft && directions != Directions.ForwardRight && directions != Directions.BackwardLeft && directions != Directions.BackwardRight)
                IsValidMove = false;
            return IsValidMove;
        }
    }
}
