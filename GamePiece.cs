using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class GamePiece : IComparable
    {
       public GamePiece(string TypeofPiece = null, string ColorofPiece = null, int PiecePositionX = 0, int PiecePositionY = 0)
        {
            PieceType = TypeofPiece; // determines type of chess piece i.e. King, Queen, etc
            PieceColor = ColorofPiece; // determines color of chess piece i.e. Black or White
            PositionX = PiecePositionX; // horizontal position of piece on board
            PositionY = PiecePositionY; // vertical position of piece on board
        }

        private string PieceType { get; set; } // private because user is not allowed to alter the type of piece
       private string PieceColor { get; set; } // private becuase user is not allowed to change the piece color
       private int PositionX { get; set; } // recieves horizontal position on board
       
       private int PositionY { get; set; } // recieves vertical position on board
        public override string ToString()
        {
            return $"The Team {PieceColor} {PieceType} has moved ({PositionX}, {PositionY }) spaces";
        }

        public override bool Equals(object obj)
        {
            if(obj is GamePiece && obj != null)
            {
                GamePiece piece = (GamePiece) obj;
                return PieceType.Equals(piece.PieceType) && PieceColor.Equals(piece.PieceColor) && horizontalMovement.Equals(piece.horizontalMovement) && verticalMovement.Equals(piece.verticalMovement);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(GamePiece otherPiece)
        {
            if(PieceColor.CompareTo(otherPiece.PieceColor) == 0)
            {
                return PieceType.CompareTo(otherPiece.PieceType);
            }
            else
            {
                return PieceColor.CompareTo(otherPiece.PieceColor);
            }
        }

        public static int verticalMovement(GamePiece piece)
        {
            return new GamePiece(piece.PositionX + 1);
        }

        public static int  horizontalMovement(GamePiece piece)
        {

        }

        public bool validMove()
        {

        }

        public string removePiece()
        {

        }
    }

    
}
