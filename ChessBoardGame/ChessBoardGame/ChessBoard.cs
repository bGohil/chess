using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGame
{
    public class ChessBoardDetails
    {
        public int HorizontalLineNumber { get; set; }
        public int VerticalLineNumber { get; set; }
        public bool IsEmpty { get; set; }
        public PieceTypes PieceType { get; set; }
    }
}
