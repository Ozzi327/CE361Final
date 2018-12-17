using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Queen : GamePiece, IComparable<Queen>
    {
        public Queen(string ColorofPiece = null, int QueenPositionX = 0, int QueenPositionY = 0)
        {
            PieceColor = ColorofPiece; // determines color of chess piece i.e. Black or White
            PositionX = QueenPositionX; // horizontal position of piece on board
            PositionY = QueenPositionY; // vertical position of piece on board

        }

        private string PieceColor { get; set; } // private becuase user is not allowed to change the piece color
        private int PositionX { get; } // recieves horizontal position on board
        private int PositionY { get; } // recieves vertical position on board

        public override string ToString()
        {
            return $"The Team {PieceColor}  Queen has moved ({PositionX}, {PositionY }) spaces";
        }




    }
} 
