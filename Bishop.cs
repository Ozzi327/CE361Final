using System;

public class Bishop : GamePiece, IComparable<Bishop>
{
    public Bishop(string PieceType, Thickness BishopPositionX, Thickness BishopPositionY, bool ColorofPiece = false) : base(PieceType, BishopPositionX, BishopPositionY, false)
    {
        PieceType = "Bishop";
        PieceColor = ColorofPiece;
        PositionX = BishopPositionX;
        PositionY = BishopPositionY;
    }


    private Thickness tempPositionX;
    private Thickness tempPositionY;


    public override string Tostring()
    {
        return $"The Team {Piececolor} Bishop has moved ({BishopPositionX}, {BishopPositionY}) spaces";
    }

    public override bool Equals(object obj) // checks if object is a King type
    {
        if (obj is Bishop && obj != null)
        {
            Bishop piece = (Bishop)obj;
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

    public void Move(double inputX, double inputY, Thickness x, Thickness y, Image BS)
    {

        if ((inputX == inputY) || (inputX == (inputY * -1)))// checks to make sure the move is diagnal of the piece otherwise wont move
        {
            x = BS.Margin;
            x.Left = x.Left + inputX * 70;
            
            x.Top = x.Top + inputx * 70;
            BS.Margin = x;
           
        }
        else
            Console.WriteLine("make x and y be the same number positive or negative dont matter");


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


    public void removePiece(Bishop a, Bishop b)
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


    
