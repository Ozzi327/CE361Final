using System;

public class Knight : GamePiece, IComparable<Knight>
{
    public Knight(string ColorofPiece = null, int BishopPositionX = 0, int BishopPositionY = 0)
    {
        PieceColor = ColorofPiece;
        PositionX = BishopPositionX;
        PositionY = BishopPositionY;
    }


    private int tempPositionX { get; set; }
    private int tempPositionY { get; set; }
}

public override string Tostring()
{
    return $"The Team {Piececolor} Knight has moved ({PositionX}, {PositionY}) spaces";
}

public override bool Equals(object obj) // checks if object is a King type
{
    if (obj is Knight && obj != null)
    {
        Knight piece = (Knight)obj;
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

public int CompareTo(Knight otherPiece)
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

public void Move(int inputX, int inputY)
{

    if ((inputX == 1) && (inputY == 0))// checks the users input since knights have a predetermined moveset
    {
        this.tempPositionX = this.PositionX + 2;
        this.tempPositionY = this.PositionY + 1;
    }
    else if ((inputX == 2) && (inputY == 0))
    {
        this.tempPositionX = this.PositionX + 2;
        this.tempPositionY = this.PositionY - 1;
    }
    else if ((inputX == 3) && (inputY == 0))
    {
        this.tempPositionX = this.PositionX - 2;
        this.tempPositionY = this.PositionY + 1;
    }
    else if ((inputX == 4) && (inputY == 0))
    {
        this.tempPositionX = this.PositionX - 2;
        this.tempPositionY = this.PositionY - 1;
    }
    else if ((inputX == 5) && (inputY == 0))
    {
        this.tempPositionX = this.PositionX + 1;
        this.tempPositionY = this.PositionY + 1;
    }
    else if ((inputX == 6) && (inputY == 0))
    {
        this.tempPositionX = this.PositionX + 1;
        this.tempPositionY = this.PositionY - 1;
    }
    else if ((inputX == 7) && (inputY == 0))
    {
        this.tempPositionX = this.PositionX - 1;
        this.tempPositionY = this.PositionY + 1;
    }
    else if ((inputX == 8) && (inputY == 0))
    {
        this.tempPositionX = this.PositionX - 1;
        this.tempPositionY = this.PositionY - 1;
    }
    else
        Console.WriteLine("invalid move, make x a value from 1-8 for its moves, leave y blank, else cant be moved there");


}

public bool validMove(Gamepiece b)
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

public static void Moveset()
{
    this.PostionX = this.tempPositionX;
    this.PositionY = this.tempPositionY;
}
public void removePiece(Knight a, Knight b)
{
    if ((b.PositionX == a.PositionX) && (b.PositionY == a.PositionX)) // checks if piece B has moved into piece A space on the board
    {
        if (b.PieceColor != a.PieceColor) // checks if piece A and piece B are the same color
        {
            a.PieceColor = null; // Piece A color is deleted
        }
    }

}


