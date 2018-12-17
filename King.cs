using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject

{
    public class King : GamePiece, IComparable<King>
    {
        public King(string ColorofPiece = null, int KingPositionX = 0, int KingPositionY = 0)
        {
            PieceColor = ColorofPiece; // determines color of chess piece i.e. Black or White
            PositionX = KingPositionX; // horizontal position of piece on board
            PositionY = KingPositionY; // vertical position of piece on board

        }

        private string PieceColor { get; set; } // private becuase user is not allowed to change the piece color
        private int PositionX { get; } // recieves horizontal position on board
        private int PositionY { get; } // recieves vertical position on board

        public override string ToString()
        {
            return $"The Team {PieceColor} King has moved ({PositionX}, {PositionY }) spaces";
        }

        public override bool Equals(object obj) // checks if object is a King type
        {
            if (obj is King && obj != null)
            {
                King piece = (King)obj;
                return PieceColor.Equals(piece.PieceColor) && PositionX.Equals(piece.PositionX) && PositionY.Equals(piece.PositionY);
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

        public int CompareTo(King otherPiece)
        {
            if (PieceColor.CompareTo(otherPiece.PieceColor) == 0)
            {
               if (PositionX.CompareTo(otherPiece.PositionX) == 0)
               {
                 return PositionY.CompareTo(otherPiece.PositionY); // gets difference of Y position of 2 pieces
               }
               else
               {
                 return PositionX.CompareTo(otherPiece.PositionX); // gets difference of X postion of 2 pieces
               }   
            }
            else
            {
                return PieceColor.CompareTo(otherPiece.PieceColor); // gets difference of color of 2 pieces
            }
        }

        public bool validMove(King a, King b)
        {
            if (((a.PositionX >= 1) && (a.PositionX <= 8)) && ((a.PositionY >= 1) && (a.PositionY <= 8))) // checks if new move is within boundaries of board
            {
                if ((a.PositionX == b.PositionY) && (a.PositionX == b.PositionY)) // checks if two pieces are on the same space on the board
                {
                    if (a.PieceColor != b.PieceColor) // checks if 2 pieces are of different color
                    {
                        return true; // valid move
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return true; // valid move 
                }
            }
            else
            {
                return false; // invalid move
            }
        }

        public void removePiece(King a, King b)
        {
            if ((b.PositionX == a.PositionX) && (b.PositionY == a.PositionX)) // checks if piece B has moved into piece A space on the board
            {
                if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
                {
                    a.PieceColor = null; // Piece A color is deleted
                }
            }

        }

        public void UpMove(King piece)
        {
            int PositionY = piece.PositionY;
            PositionY = PositionY + 1; // moves position of a chess piece upwards vertically
        }
        public void DownMove(King piece)
        {
            int PositionY = piece.PositionY;
            PositionY = PositionY - 1; // moves position of a chess piece downwards vertically 
        }

        public void RightMove(King piece)
        {
            int PositionX = piece.PositionX;
            PositionX = PositionX + 1; // moves position of a chess piece rightwards horizontally
        }
        public void LeftMove(King piece)
        {
            int PositionX = piece.PositionX;
            PositionX = PositionX - 1; // moves position of a chess piece leftwards horizontally
        }
    }  
}
