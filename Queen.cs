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

        public override bool Equals(object obj) // checks if object is a Queen type
        {
            if (obj is Queen && obj != null)
            {
                Queen piece = (Queen)obj;
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
        public int CompareTo(Queen otherPiece)
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

        public bool validMove(Queen a, Queen b)
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

        public void removePiece(Queen a, Queen b)
        {
            if ((b.PositionX == a.PositionX) && (b.PositionY == a.PositionX)) // checks if piece B has moved into piece A space on the board
            {
                if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
                {
                    a.PieceColor = null; // Piece A color is deleted
                }
            }

        }

        public  void UpMove(Queen piece, int inputY)
        {
            int PositionY = piece.PositionY;
            PositionY = PositionY + inputY; // moves position of chess piece up vertically based off of user input
        
        }
        public  void DownMove(Queen piece, int inputY)
        {
            int PositionY = piece.PositionY;
            PositionY = PositionY - inputY; // moves position of a chess piece downwards vertically 
        }

        public  void RightMove(Queen piece, int inputX)
        {
            int PositionX = piece.PositionX;
            PositionX = PositionX + inputX; // moves position of a chess piece rightwards horizontally
        }
        public  void LeftMove(Queen piece, int inputX)
        {
            int PositionX = piece.PositionX;
            PositionX = PositionX - inputX; // moves position of a chess piece leftwards horizontally
        }

        public void UpLeftDiagonalMove(Queen piece, int input)
        {
            int PositionX = piece.PositionY;
            int PositionY = piece.PositionX;

            PositionX = piece.PositionX - input;
            PositionY = piece.PositionY + input;
        }

        public void DownRightDiagonalMove(Queen piece, int input)
        {
            int PositionX = piece.PositionY;
            int PositionY = piece.PositionX;

            PositionX = piece.PositionX + input;
            PositionY = piece.PositionY - input;
        }

        public void UpRightDiagonalMove(Queen piece, int input)
        {
            int PositionX = piece.PositionY;
            int PositionY = piece.PositionX;

            PositionX = piece.PositionX + input;
            PositionY = piece.PositionY + input;
        }

        public void DownLeftDiagonalMove(Queen piece, int input)
        {
            int PositionX = piece.PositionY;
            int PositionY = piece.PositionX;

            PositionX = piece.PositionX - input;
            PositionY = piece.PositionY - input;
        }


    }
} 
