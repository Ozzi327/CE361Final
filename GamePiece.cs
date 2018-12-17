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

         public static void UpMove(GamePiece piece)
        {
            int PositionY = piece.PositionY;
            PositionY = PositionY + 1; // moves position of a chess piece upwards vertically
        }
         public static void DownMove(GamePiece piece)
        {
            int PositionY = piece.PositionY;
            PositionY = PositionY - 1; // moves position of a chess piece downwards vertically 
        }

        public static void RightMove(GamePiece piece)
        {
            int PositionX = piece.PositionX;
            PositionX = PositionX + 1; // moves position of a chess piece rightwards horizontally
        }
        public static void LeftMove(GamePiece piece)
        {
            int PositionX = piece.PositionX;
            PositionX = PositionX - 1; // moves position of a chess piece leftwards horizontally
        }

        public bool validMove(GamePiece a, GamePiece b)
        {
            if( ((a.PositionX >= 1) && (a.PositionX <= 8)) && ((a.PositionY >= 1) && (a.PositionY <= 8))) // checks if new move is within boundaries of board
            {
               if((a.PositionX == b.PositionY) && (a.PositionX == b.PositionY)) // checks if two pieces are on the same space on the board
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

         public void removePiece(GamePiece a, GamePiece b)
        {
            if ((b.PositionX == a.PositionX) && (b.PositionY == a.PositionX)) // checks if piece B has moved into piece A space on the board
            {
                if(b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
                {
                    a.PieceColor = null; // Piece A color is deleted
                    a.PieceType = null; // Piece A type is deleted

                    
                }
            }
                 
        }

       
    }

    
}
