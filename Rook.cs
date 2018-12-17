using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rook
{
    public Rook() : GamePiece
	{
            public Rook(string ColorofPiece = null, int PiecePositionX = 0, int PiecePositionY = 0)
            {
                PieceType = "Rook";
                PieceColor = ColorofPiece; // determines color of chess piece i.e. Black or White
                PositionX = PiecePositionX; // horizontal position of piece on board
                PositionY = PiecePositionY; // vertical position of piece on board
            }

            private int tempPositionX { get; set; }
            private int tempPositionY { get; set; }

            public override string ToString()
            {
                return $"The Team {PieceColor} {PieceType} has moved ({PositionX}, {PositionY }) spaces";
            }

            public override bool Equals(object obj)
            {
                if (obj is Rook && obj != null)
                {
                    Rook piece = (Rook)obj;
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

            public int CompareTo(Rook otherPiece)
            {
                if (PieceColor.CompareTo(otherPiece.PieceColor) == 0)
                {
                    if (PieceType.CompareTo(otherPiece.PieceType) == 0)
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
                        return PieceType.CompareTo(otherPiece.PieceType); // gets difference of types of 2 pieces
                    }
                }
                else
                {
                    return PieceColor.CompareTo(otherPiece.PieceColor); // gets difference of color of 2 pieces
                }
            }

            public static void Move(int inputX, int inputY)
            {
                if (!inputY)
                    this.tempPositionX = this.PositionX + inputX; // moves position of a chess piece horizontally
                else if (!inputX)
                    this.tempPositionY = this.PositionY + inputY;
                else
                    
            }
            public bool validMove(piece b)
            {
                if (((this.PositionX >= 1) && (this.PositionX <= 8)) && ((this.PositionY >= 1) && (this.PositionY <= 8))) // checks if new move is within boundaries of board
                {
                    if ((this.PositionX == b.PositionY) && (this.PositionX == b.PositionY)) // checks if two pieces are on the same space on the board
                    {
                        if (this.PieceColor != b.PieceColor) // checks if 2 pieces are of different color
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
            
            public static void MoveSet()
            {
                 this.Positionx = this.tempPositionX;
                 this.PositionY = this.tempPositionY;
            }

            public void removePiece(Rook a, Rook b)
            {
                if ((b.PositionX == a.PositionX) && (b.PositionY == a.PositionX)) // checks if piece B has moved into piece A space on the board
                {
                    if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
                    {
                        a.PieceColor = null; // Piece A color is deleted
                        a.PieceType = null; // Piece A type is deleted


                    }
                }

            }


        }
	}
}
