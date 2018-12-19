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
    public class Rook: GamePiece
	{
            public Rook( string PieceType, Thickness PiecePositionX, Thickness PiecePositionY, bool ColorofPiece = false): base(PieceType, PiecePositionX, PiecePositionY, false) 
    {
        PieceType = "Rook";
        PieceColor = ColorofPiece; // determines color of chess piece i.e. Black or White
        PositionX = PiecePositionX; // horizontal position of piece on board
        PositionY = PiecePositionY; // vertical position of piece on board



        }

      private Thickness tempPositionX;
    private Thickness tempPositionY;
       

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
                return PieceType.CompareTo(otherPiece.PieceType); // gets difference of types of 2 pieces
            }
        }
        else
        {
            return PieceColor.CompareTo(otherPiece.PieceColor); // gets difference of color of 2 pieces
        }
    }

        public void Move(double inputX, double inputY, Thickness x, Image gh)
        {
           if (inputY == 0)
            {
                x = gh.Margin;
                x.Left = x.Left + inputX*70; // moves position of a chess piece horizontally
                gh.Margin = x;
            }
            else if (inputX == 0)
            {
               x = gh.Margin;
                x.Top = x.Top + inputY*70;
               
              gh.Margin = x;

                
            }

        }
   public bool validMove(GamePiece b)
    {
        if (((this.PositionX.Left >= 200) && (this.PositionX.Left <=690)) && ((this.PositionY.Top >= 70) && (this.PositionY.Top <= 560))) // checks if new move is within boundaries of board
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

 

        public void removePiece(Rook a, Rook b)
    {
        if ((b.PositionX.Left == a.PositionX.Left) && (b.PositionY.Top == a.PositionX.Left)) // checks if piece B has moved into piece A space on the board
        {
            if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
            {
                a.PieceColor = true; // Piece A color is deleted
                a.PieceType = null; // Piece A type is deleted


            }
        }

    }


}
	}
    
 