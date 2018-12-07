using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class GamePiece : IComparable<GamePiece>
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
        private int PositionX { get; } // recieves horizontal position on board
     
        private int PositionY { get; } // recieves vertical position on board

        public override string ToString()
        {
            return $"The Team {PieceColor} {PieceType} has moved ({PositionX}, {PositionY }) spaces";
        }

        public override bool Equals(object obj)
        {
            if(obj is GamePiece && obj != null)
            {
                GamePiece piece = (GamePiece) obj;
                return PieceType.Equals(piece.PieceType) && PieceColor.Equals(piece.PieceColor) && PositionX.Equals(piece.PositionX) && PositionY.Equals(piece.PositionY);
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
                if(PieceType.CompareTo(otherPiece.PieceType) == 0)
                {
                    if(PositionX.CompareTo(otherPiece.PositionX) == 0)
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
                    return PieceType.CompareTo(otherPiece.PieceType); // gets difference of types of 2 pieces
                }
            }
            else
            {
                return PieceColor.CompareTo(otherPiece.PieceColor); // gets difference of color of 2 pieces
            }
        }

        public static int verticalMove(GamePiece piece)
        {
            int PositionX = piece.PositionX;

            PositionX = PositionX + 1; // moves position of a chess piece horizontally

            return new GamePiece(piece.PositionX);
        }

        public static int  horizontalMove(GamePiece piece)
        {
            int PositionY = piece.PositionY;

            PositionY = PositionY + 1; // moves position of a chess piece vertically

            return new GamePiece(piece.PositionY);
        }

        public bool validMove(GamePiece piece, GamePiece otherpiece)
        {
            if( ((piece.PositionX >= 1) && (piece.PositionX <= 8)) && ((piece.PositionY >= 1) && (piece.PositionY <= 8))) // checks if new move is within boundaries of board
            {
               if((piece.PositionX == otherpiece.PositionY) && (piece.PositionX == otherpiece.PositionY)) // checks if two pieces are on the same space on the board
                {
                    if (piece.PieceColor != otherpiece.PieceColor) // checks if 2 pieces are of different color
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

         public string removePiece(GamePiece piece, GamePiece otherpiece)
        {
            if ((otherpiece.PositionX == piece.PositionX) && (otherpiece.PositionY == piece.PositionX)) // checks if piece B has moved into piece A space on the board
            {
                if(otherpiece.PieceColor != piece.PieceColor) // checks if piece A and piece B are the same color
                {
                    piece = null; // Piece A is deleted
                }
            }
                 
        }

       
    }

    
}
