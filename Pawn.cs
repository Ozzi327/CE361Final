using System;

public class Pawn : GamePiece, IComparable<Bishop>
{
    public Pawn(string PieceType, Thickness BishopPositionX, Thickness BishopPositionY, bool ColorofPiece = false) : base(PieceType, BishopPositionX, BishopPositionY, false)
    {
        PieceType = "Pawn";
        PieceColor = ColorofPiece;
        PositionX = BishopPositionX;
        PositionY = BishopPositionY;
    }


    private Thickness tempPositionX;
    private Thickness tempPositionY;
    private bool firstmove = 0;
}

public override string Tostring()
{
    return $"The Team {Piececolor} Bishop has moved ({PositionX}, {PositionY}) spaces";
}

public override bool Equals(object obj) // checks if object is a King type
{
    if (obj is Pawn && obj != null)
    {
        Bishop piece = (Pawn)obj;
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

public int CompareTo(Bishop otherPiece)
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

public bool validMove(Gamepiece b)
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

public void removePiece(Bishop a, Bishop b)
{
    if ((b.PositionX.Left == a.PositionX.Left) && (b.PositionY.Top == a.PositionX.Left)) // checks if piece B has moved into piece A space on the board
    {
        if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
        {
            a.PieceColor = null; // Piece A color is deleted
        }
    }

}

public void Move(double inputX, double inputY, Thickness x, Thickness y, Image BS)
{

    if (!firstmove && (inputY == 0) && (inputX < 3) && (inputX > 0) && PieceColor)//checks if the move is the first one or not for pawns
    {
        x = BS.Margin;
        x.Left = x.Left + inputX * 70;
        BS.Margin = x;
        firstmove = 1;
    }

    else if (firstmove && (inputY == 0) && (inputX < 2) && (inputX > 0) && PieceColor)
    {
        x = BS.Margin;
        x.Left = x.Left + inputX * 70;
        BS.Margin = x;
        firstmove = 1;
    }
    else if (!firstmove && (inputY == 0) && (inputX > -3) && (inputX < 0) && !PieceColor)//checks if the move is the first one or not for pawns
    {
        x = BS.Margin;
        x.Left = x.Left + inputX * 70;
        BS.Margin = x;
        firstmove = 1;
    }
    else if (firstmove && (inputY == 0) && (inputX > -2) && (inputX < 0) && !PieceColor)
    {
        x = BS.Margin;
        x.Left = x.Left + inputX * 70;
        BS.Margin = x;
        firstmove = 1;
    }
    else if(((inputY == inputX)||(inputX == -inputY))&&((inputX == -1)||(inputX == 1)))
    {
        x = BS.Margin;
        x.Left = x.Left + inputX * 70;
        y = BS.Margin;
        y.Top = y.Top + inputY * 70;
        BS.Margin = x;
        BS.Margin = y;
    }
}

