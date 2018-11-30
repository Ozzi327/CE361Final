using System;
/// <summary>
/// jonathan tran
/// 819325761
/// this is the class of individual spaces
/// </summary>
public class space
{
    private bool occupied { get; set; }; //to see if there is a piece here
    private int x { get; set; }; //x-axis of the piece 
    private int y { get; set; }; //y-axis of the piece
    //may have to add something for the color of the piece on the tile

    public space()
    {
        this.occupied = false;
        this.x = 0;
        this.y = 0;
    }
    /// <summary>
    /// EX constructor for the space
    /// </summary>
    /// <param name="X"></param>
    /// <param name="Y"></param>
    public space(int X, int Y,bool occ)
    {
        this.occupied = occ;
        if (X > = 0 || X <= 7)
        {
            this.x = X;
        }
        if (Y > = 0 || Y <= 7)
        {
            this.y = Y;
        }
    }

    public inSpace()
    {
        this.occupied = true;
    }

    public outSpace()
    {
        this.occupied = false;
    }
        
}
