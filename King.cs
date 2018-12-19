using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject

{
    public class King : GamePiece, IComparable<King>
    {
        public King(string PieceType, bool ColorofPiece = false, Thickness KingPositionX = 0, Thickness KingPositionY = 0) : base(PieceType, false, KingPositionX, KingPositionY)
        {
            PieceColor = ColorofPiece; // determines color of chess piece i.e. Black or White
            PositionX = KingPositionX; // horizontal position of piece on board
            PositionY = KingPositionY; // vertical position of piece on board
            PieceType = "King";

        }

        private Thickness tempPositionX; // recieves horizontal position on board
        private Thickness tempPositionY; // recieves vertical position on board

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
                if (PositionX.Left.CompareTo(otherPiece.PositionX.Left) == 0)
                {
                    return PositionY.Top.CompareTo(otherPiece.PositionY.Top); // gets difference of Y position of 2 pieces
                }
                else
                {
                    return PositionX.Left.CompareTo(otherPiece.PositionX.Left); // gets difference of X postion of 2 pieces
                }
            }
            else
            {
                return PieceColor.CompareTo(otherPiece.PieceColor); // gets difference of color of 2 pieces
            }
        }

        public bool validMove(GamePiece a)
        {
            if (((this.PositionX.Left >= 200) && (this.PositionX.Left <= 690)) && ((this.PositionY.Top >= 70) && (this.PositionY.Top <= 560))) // checks if new move is within boundaries of board
            {
                if ((this.PositionX == a.PositionY) && (this.PositionX == a.PositionY)) // checks if two pieces are on the same space on the board
                {
                    if (this.PieceColor != a.PieceColor) // checks if 2 pieces are of different color
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
            if ((b.PositionX.Left == a.PositionX.Left) && (b.PositionY.Top == a.PositionY.Top)) // checks if piece B has moved into piece A space on the board
            {
                if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
                {
                    a.PieceColor = null; // Piece A color is deleted
                }
            }

        }

        public void Move(double inputX, double inputY, Thickness X, Thickness Y, Image BS)
        {
            if ((inputX == 0) && (inputY == 1))
            {
                Y.Top = Y.Top + 70; // moves one space to up vertically 
                BS.Margin = Y;
            }
            if ((inputX == 0) && (inputY == -1))
            {
                Y.Top = Y.Top - 70; // moves one space down vertically
                BS.Margin = Y;
            }
            if ((inputX == 1) && (inputY == 0))
            {
                X.Left = X.Left + 70; // moves one space to the right horizontally
                BS.Margin = X;
            }
            if ((inputX == -1) && (inputY == -1))
            {
                X.Left = X.Left - 70; // moves one space to the left horizontally
                X.Top = X.Top - 70; // moves one space down vertically
                BS.Margin = X; // Left Down Diagonal Move

            }
            if ((inputX == -1) && (inputY == 1))
            {
                X.Left = X.Left - 70; // moves one space to the left horizontally
                X.Top = X.Top + 70; // moves one space up vertically
                BS.Margin = X; // Left Up Diagonal Move
            }
            if ((inputX == 1) && (inputY == -1))
            {
                Y.Left = Y.Left + 70; // moves one space to the left horizontally
                Y.Top = Y.Top - 70; // moves one space down vertically
                BS.Margin = Y; // Right Down Diagonal Move
            }
            if ((inputX == 1) && (inputY == 1))
            {
                Y.Left = Y.Left + 70; // moves one space to the left horizontally
                Y.Top = Y.Top + 70; // moves one space up vertically
                BS.Margin = X; // Right Up Diagonal Move
            }
            else if ((inputX == 0) && (inputY == 0))
            {
                X.Left = X.Left; // no horizontal movement
                X.Top = X.Top;  // no vertical movement
                BS.Margin = X; // same original movement
            }
        }
    }
}

   



