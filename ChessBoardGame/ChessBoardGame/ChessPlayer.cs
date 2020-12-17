using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGame
{
    public class ChessPlayer
    {
        public PlayerTypes PlayerType { get; set; }
        public bool IsCurrentPlayer { get; set; }
        public string HistoryDetails { get; set; }
        public Dictionary<PieceTypes,ChessBoardDetails> CurrentPositions { get; set; }

        public Dictionary<PieceTypes, ChessBoardDetails> createInitialBoard()
        {
            Dictionary<PieceTypes, ChessBoardDetails> initialPosition = new Dictionary<PieceTypes, ChessBoardDetails>();
            //set initial position of rook
            
            for(int i = 1; i <= 8; i++)
            {

            }
            return initialPosition;
        }
    }
}
