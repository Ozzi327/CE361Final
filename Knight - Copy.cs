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

public class Knight : GamePiece, IComparable<Knight>
{
    public Knight(string PieceType, Thickness KnightPositionX , Thickness KnightPositionY , bool ColorofPiece = false) : base(PieceType, KnightPositionX, KnightPositionY, false)
    {
        PieceType = "Knight";
        PieceColor = ColorofPiece;
        PositionX = KnightPositionX;
        PositionY = KnightPositionY;
    }


    private Thickness tempPositionX;
    private Thickness tempPositionY;

    public override string ToString()
    {
        return $"The Team Knight has moved ({PositionX}, {PositionY}) spaces";
    }

    public override bool Equals(object obj) // checks if object is a King type
    {
        if (obj is Knight && obj != null)
        {
            Knight piece = (Knight)obj;
            return PieceColor.Equals(piece.PieceColor) && PositionX.Left.Equals(piece.PositionX.Left) && PositionY.Top.Equals(piece.PositionY.Top);
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

    public int CompareTo(Knight otherPiece)
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

    public void Move(double inputX,double inputY, Thickness x, Thickness y, Image Kn)
    {

        if ((inputX == 2) && (inputY == 1))// checks the users input since knights have a predetermined moveset
        {
            x = Kn.Margin;
            x.Left = x.Left + 2 * 70;
          
            x.Top = x.Top + 1 * 70;
            Kn.Margin = x;
        
        }
        else if ((inputX == 1) && (inputY == 2))
        {
            x = Kn.Margin;
            x.Left = x.Left + 2 * 70;
          
            x.Top = x.Top - 1 * 70;
            Kn.Margin = x;
            
        }
        else if ((inputX == -2 )&& (inputY == 1))
        {
            x = Kn.Margin;
            x.Left = x.Left - 2 * 70;
           
            x.Top = x.Top + 1 * 70;
            Kn.Margin = x;
        
        }
        else if ((inputX == -2) && (inputY == -1))
        {
            x = Kn.Margin;
            x.Left = x.Left - 2 * 70;
            y = Kn.Margin;
            y.Top = y.Top - 1 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 1) && (inputY == 2))
        {
            x = Kn.Margin;
            x.Left = x.Left + 1 * 70;
            y = Kn.Margin;
            y.Top = y.Top + 2 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 1) && (inputY == -2))
        {
            x = Kn.Margin;
            x.Left = x.Left + 1 * 70;

            x.Top = x.Top - 2 * 70;
            Kn.Margin = x;

        }
        else if ((inputX == -1) && (inputY == 2))
        {
            x = Kn.Margin;
            x.Left = x.Left - 1 * 70;

            x.Top = x.Top + 2 * 70;
            Kn.Margin = x;

        }
        else if ((inputX == -1) && (inputY == -2))
        {
            x = Kn.Margin;
            x.Left = x.Left - 1 * 70;

            x.Top = x.Top - 2 * 70;
            Kn.Margin = x;

        }
        else
            Kn.Margin= x;
          


    }

    public bool validMove(GamePiece b)
    {
        if (((this.PositionX.Left >= 1) && (this.PositionX.Left <= 8)) && ((this.PositionY.Top >= 1) && (this.PositionY.Top <= 8))) // checks if new move is within boundaries of board
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


    public void removePiece(Knight a, Knight b)
    {
        if ((b.PositionX.Left == a.PositionX.Left) && (b.PositionY.Top == a.PositionY.Top)) // checks if piece B has moved into piece A space on the board
        {
            if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
            {
                a.PieceColor = false; // Piece A color is deleted
            }
        }

    }
}