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


namespace ChessFinal
{
    public class GamePiece : IComparable<GamePiece>
    {
        public GamePiece( string PieceType, Thickness PiecePositionX , Thickness PiecePositionY, bool ColorofPiece = false)
        {
            
            PieceColor = ColorofPiece; // determines color of chess piece i.e. Black or White
            PositionX = PiecePositionX; // horizontal position of piece on board
            PositionY = PiecePositionY; // vertical position of piece on board
        }


        public string PieceType { get; set; } // private because user is not allowed to alter the type of piece
        public bool PieceColor { get; set; } // private becuase user is not allowed to change the piece color
        public Thickness PositionX { get; set; } // recieves horizontal position on board
        public Thickness PositionY { get; set; } // recieves vertical position on board

        public override string ToString()
        {
            return $"The Team {PieceColor} {PieceType} has moved ({PositionX}, {PositionY }) spaces";
        }

        public override bool Equals(object obj)
        {
            if (obj is GamePiece && obj != null)
            {
                GamePiece piece = (GamePiece)obj;
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

        public Thickness MoveRight(GamePiece piece)
        {
            Thickness PositionX = piece.PositionX;

            PositionX.Left = PositionX.Left + 70; // moves position of a chess piece horizontally

            return PositionX;
        }

        public void MoveUp(GamePiece piece)
        {
            Thickness PositionY = piece.PositionY;

            PositionY.Top = PositionY.Top - 70 ; // moves position of a chess piece vertically

         
        }
        public void MoveDown(GamePiece piece)
        {
            Thickness PositionY = piece.PositionY;

            PositionY.Top = PositionY.Top + 70; // moves position of a chess piece vertically


        }
        public void MoveLeft(GamePiece piece)
        {
            Thickness PositionX = piece.PositionX;

            PositionX.Left = PositionX.Left - 70; // moves position of a chess piece horizontally


        }

        public void checkmove(Thickness x, Thickness x2, Thickness x3, Thickness x4, Thickness x5, Thickness x6, Thickness x7, Thickness x8, Thickness x9, Thickness x10, Thickness x11, Thickness x12, Thickness x13, Thickness x14, Thickness x15, Thickness x16, Thickness x17, Image one, Image two, Image three , Image four , Image five , Image six , Image seven,  Image eight, Image nine, Image ten, Image eleven, Image twelve , Image thirteen , Image fourteen, Image fifteen , Image sixteen, Image Seventeen )
        {
            x = one.Margin;
            x2 = two.Margin;
            x3 = three.Margin;
            x4 = four.Margin;
            x5 = five.Margin;
            x6 = six.Margin;
            x7 = seven.Margin;
            x8 = eight.Margin;
            x9 = nine.Margin;
            x10 = ten.Margin;
            x11= eleven.Margin;
            x12 = twelve.Margin;
            x13 = thirteen.Margin;
            x14 = fourteen.Margin;
            x15 = fifteen.Margin;
            x16 = sixteen.Margin;
            x17 = Seventeen.Margin;
             if((x.Left == x2.Left) &&( x.Top == x2.Top))
            {
                x2.Top = 0;
                x2.Left = 800;
                two.Margin = x2;
            }
            if (x.Left == x3.Left && x.Top == x3.Top)
            {
                x3.Top = 0;
                x3.Left = 800;
                three.Margin = x3;
            }
            if (x.Left == x7.Left && x.Top == x7.Top)
            {
                x7.Top = 0;
                x7.Left = 800;
                seven.Margin = x7;
            }
            if (x.Left == x4.Left && x.Top == x4.Top)
            {
                x4.Top = 0;
                x4.Left = 800;
                four.Margin = x4;
            }
            if (x.Left == x5.Left && x.Top == x5.Top)
            {
                x5.Top = 0;
                x5.Left = 800;
                five.Margin = x5;
            }
            if (x.Left == x6.Left && x.Top == x6.Top)
            {
                x6.Top = 0;
                x6.Left = 800;
                six.Margin = x6;
            }
            if (x.Left == x8.Left && x.Top == x8.Top)
            {
                x8.Top = 0;
                x8.Left = 800;
                eight.Margin = x8;
            }
            if (x.Left == x9.Left && x.Top == x9.Top)
            {
                x9.Top = 0;
                x9.Left = 800;
                nine.Margin = x9;
            }
            if (x.Left == x10.Left && x.Top == x10.Top)
            {
                x10.Top = 0;
                x10.Left = 800;
                ten.Margin = x10;
            }
            if (x.Left == x11.Left && x.Top == x11.Top)
            {
                x11.Top = 0;
                x11.Left = 800;
                eleven.Margin = x11;
            }
            if (x.Left == x12.Left && x.Top == x12.Top)
            {
                x12.Top = 0;
                x12.Left = 800;
                twelve.Margin = x12;
            }
            if (x.Left == x13.Left && x.Top == x13.Top)
            {
                x13.Top = 0;
                x13.Left = 800;
                thirteen.Margin = x13;
            }
            if (x.Left == x14.Left && x.Top == x14.Top)
            {
                x14.Top = 0;
                x14.Left = 800;
                fourteen.Margin = x14;
            }
            if (x.Left == x15.Left && x.Top == x15.Top)
            {
                x15.Top = 0;
                x15.Left = 800;
                fifteen.Margin = x15;
            }
            if (x.Left == x16.Left && x.Top == x16.Top)
            {
                x16.Top = 0;
                x16.Left = 800;
                sixteen.Margin = x16;
            }
            if (x.Left == x17.Left && x.Top == x17.Top)
            {
                x17.Top = 0;
                x17.Left = 800;
                Seventeen.Margin = x17;
            }






        }
        public bool validMove(GamePiece a, GamePiece b)
        {
            if (((a.PositionX.Left >= 200) && (a.PositionX.Top <= 690)) && ((a.PositionY.Top >= 70) && (a.PositionY.Top<= 690))) // checks if new move is within boundaries of board
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

        public void removePiece(GamePiece a, GamePiece b)
        {
            if ((b.PositionX == a.PositionX) && (b.PositionY == a.PositionX)) // checks if piece B has moved into piece A space on the board
            {
                if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
                {
                    a.PieceColor = false; // Piece A color is deleted
                    a.PieceType = null; // Piece A type is deleted


                }
            }

        }


    }


}