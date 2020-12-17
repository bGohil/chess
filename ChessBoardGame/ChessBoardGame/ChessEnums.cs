using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGame
{
    public enum Steps
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight
    }
    public enum PlayerTypes
    {
        WhitePlayer = 1,
        BlackPlayer
    }
    public enum PieceTypes
    {
        King =1,
        Queen,
        Bishop,
        Knight,
        Rook,
        Pawn
    }
    public enum Directions
    {
        Forward = 1,
        Backward,
        Left,
        Right,
        ForwardLeft,
        ForwardRight,
        BackwardLeft,
        BackwardRight
    }
}
