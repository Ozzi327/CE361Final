using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ChessFinal;
using Windows.UI.Xaml.Media.Imaging;
namespace ChessFinal
{
    public class Queen : GamePiece, IComparable<Queen>
    {
        public Queen(string PieceType, Thickness QueenPositionX , Thickness QueenPositionY , bool ColorofPiece = false) : base(PieceType, QueenPositionX, QueenPositionY, false)
        {
            PieceType = "Queen";
            PieceColor = ColorofPiece; // determines color of chess piece i.e. Black or White
            PositionX = QueenPositionX; // horizontal position of piece on board
            PositionY = QueenPositionY; // vertical position of piece on board

        }

        private Thickness tempPositionX;
        private Thickness tempPositionY;

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

        public bool validMove(GamePiece b)
        {
            if (((this.PositionX.Left >= 200) && (this.PositionX.Left <= 690)) && ((this.PositionY.Top >= 70) && (this.PositionY.Top <= 560))) // checks if new move is within boundaries of board
            {
                if ((this.PositionX.Left == b.PositionY.Top) && (this.PositionX.Left == b.PositionY.Top)) // checks if two pieces are on the same space on the board
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

        public void removePiece(Queen a, Queen b)
        {
            if ((b.PositionX.Left == a.PositionX.Left) && (b.PositionY.Top == a.PositionY.Top)) // checks if piece B has moved into piece A space on the board
            {
                if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
                {
                    a.PieceColor = false; // Piece A color is deleted
                }
            }

        }
        public void Move(double inputX, double inputY, Thickness x, Thickness y, Image gh)
        {
            if ((inputX == inputY) || (inputX == (inputY * -1)))// checks to make sure the move is diagnal of the piece otherwise wont move
            {
                x = gh.Margin;
                x.Left = x.Left + inputX * 70;

                x.Top = x.Top + inputY * 70;
                gh.Margin = x;

            }
            if (inputY == 0)
            {
                x = gh.Margin;
                x.Left = x.Left + inputX * 70; // moves position of a chess piece horizontally
                gh.Margin = x;
            }
            else if (inputX == 0)
            {
                x = gh.Margin;
                x.Top = x.Top + inputY * 70;

                gh.Margin = x;


            }

        }


    }
}