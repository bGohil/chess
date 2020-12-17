using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGame
{
    public class King
    {
        public bool CheckIsValidMove(int numberOftep)
        {
            bool IsValidMove = false;
            if (numberOftep != 1)
                IsValidMove =  false;
            
            return IsValidMove;
        }
    }
}
