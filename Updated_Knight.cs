using System;

public class Knight : GamePiece, IComparable<Knight>
{
    public Knight(string PieceType, Thickness KnightPositionX = 0, Thickness KnightPositionY = 0, bool ColorofPiece = false) : base(PieceType, KnightPositionX, KnightPositionY, false)
    {
        PieceType = "Knight";
        PieceColor = ColorofPiece;
        PositionX = BishopPositionX;
        PositionY = BishopPositionY;
    }


    private Thickness tempPositionX;
    private Thickness tempPositionY;

    public override string Tostring()
    {
        return $"The Team {Piececolor} Knight has moved ({PositionX}, {PositionY}) spaces";
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

    public void Move(double inputX, double inputY, Thickness x, Thickness y, Image Kn)
    {

        if ((inputX == 1) && (inputY == 0))// checks the users input since knights have a predetermined moveset
        {
            x = Kn.Margin;
            x.Left = x.Left + 2 * 70;
            y = Kn.Margin;
            y.Top = y.Top + 1 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 2) && (inputY == 0))
        {
            x = Kn.Margin;
            x.Left = x.Left + 2 * 70;
            y = Kn.Margin;
            y.Top = y.Top - 1 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 3) && (inputY == 0))
        {
            x = Kn.Margin;
            x.Left = x.Left - 2 * 70;
            y = Kn.Margin;
            y.Top = y.Top + 1 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 4) && (inputY == 0))
        {
            x = Kn.Margin;
            x.Left = x.Left - 2 * 70;
            y = Kn.Margin;
            y.Top = y.Top - 1 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 5) && (inputY == 0))
        {
            x = Kn.Margin;
            x.Left = x.Left + 1 * 70;
            y = Kn.Margin;
            y.Top = y.Top + 2 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 6) && (inputY == 0))
        {
            x = Kn.Margin;
            x.Left = x.Left + 1 * 70;
            y = Kn.Margin;
            y.Top = y.Top - 2 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 7) && (inputY == 0))
        {
            x = Kn.Margin;
            x.Left = x.Left - 1 * 70;
            y = Kn.Margin;
            y.Top = y.Top + 2 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else if ((inputX == 8) && (inputY == 0))
        {
            x = Kn.Margin;
            x.Left = x.Left - 1 * 70;
            y = Kn.Margin;
            y.Top = y.Top - 2 * 70;
            Kn.Margin = x;
            Kn.Margin = y;
        }
        else
            Console.WriteLine("invalid move, make x a value from 1-8 for its moves, leave y blank, else cant be moved there");


    }

    public bool validMove(Gamepiece b)
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

    public static void Moveset()
    {
        this.PostionX = this.tempPositionX;
        this.PositionY = this.tempPositionY;
    }
    public void removePiece(Knight a, Knight b)
    {
        if ((b.PositionX.Left == a.PositionX.Left) && (b.PositionY.Top == a.PositionY.Top)) // checks if piece B has moved into piece A space on the board
        {
            if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
            {
                a.PieceColor = null; // Piece A color is deleted
            }
        }

    }
}
