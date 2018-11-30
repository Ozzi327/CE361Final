using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePiece
{
    public class King
    {
        public King()
        {
            King = new int[board.x, board.y]; // king's location on the board using x and y coordinates

            if(board.x == +1 && board.y == +0) // moves right on the board by 1 space
            {
                if((board.x >= 0 && board.x <= 7) && (board.y >= 0 && board.y <= 7)) // if move is within the 8x8 board
                { 
                    if ((player.color[board.x, board.y]) != (player.color[board.x, board.y])) // if space isn't occupied by a piece of the same color or a piece of another color  
                    { 
                       return true; //  move is valid
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return false; // invalid move
                }
            }
            else if (board.x == -1 && board.y == +0) // moves left on the board by 1 space
            {
                if ((board.x >= 0 && board.x <= 7) && (board.y >= 0 && board.y <= 7)) // if move is within the 8x8 board
                {
                    if ((player.color[board.x, board.y]) != (player.color[board.x, board.y])) // if space isn't occupied by a piece of the same color or a piece of another color  
                    {
                        return true; //  move is valid
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return false; // invalid move
                }
            }
            else if (board.x == +0 && board.y == +1) // moves up the board 1 space
            {
                if ((board.x >= 0 && board.x <= 7) && (board.y >= 0 && board.y <= 7)) // if move is within the 8x8 board
                {
                    if ((player.color[board.x, board.y]) != (player.color[board.x, board.y])) // if space isn't occupied by a piece of the same color or a piece of another color  
                    {
                        return true; //  move is valid
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return false; // invalid move
                }
            }
            else if (board.x == +0 && board.y == -1) // moves down the board 1 space
            {
                if ((board.x >= 0 && board.x <= 7) && (board.y >= 0 && board.y <= 7)) // if move is within the 8x8 board
                {
                    if ((player.color[board.x, board.y]) != (player.color[board.x, board.y])) // if space isn't occupied by a piece of the same color or a piece of another color  
                    {
                        return true; //  move is valid
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return false; // invalid move
                }
            }
            else if (board.x == +1 && board.y == +1) // moves up the board diagonally to the right 1 space
            {
                if ((board.x >= 0 && board.x <= 7) && (board.y >= 0 && board.y <= 7)) // if move is within the 8x8 board
                {
                    if ((player.color[board.x, board.y]) != (player.color[board.x, board.y])) // if space isn't occupied by a piece of the same color or a piece of another color  
                    {
                        return true; //  move is valid
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return false; // invalid move
                }
            }
            else if (board.x == -1 && board.y == -1) // moves down the board diagonally to left 1 space
            {
                if ((board.x >= 0 && board.x <= 7) && (board.y >= 0 && board.y <= 7)) // if move is within the 8x8 board
                {
                    if ((player.color[board.x, board.y]) != (player.color[board.x, board.y])) // if space isn't occupied by a piece of the same color or a piece of another color  
                    {
                        return true; //  move is valid
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return false; // invalid move
                }
            }
            else if (board.x == -1 && board.y == +1) // moves up the board diagonally to the left 1 space
            {
                if ((board.x >= 0 && board.x <= 7) && (board.y >= 0 && board.y <= 7)) // if move is within the 8x8 board
                {
                    if ((player.color[board.x, board.y]) != (player.color[board.x, board.y])) // if space isn't occupied by a piece of the same color or a piece of another color  
                    {
                        return true; //  move is valid
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return false; // invalid move
                }
            }
            else if (board.x == +1 && board.y == -1) // moves down the board diagonally to the right 1 space
            {
                if ((board.x >= 0 && board.x <= 7) && (board.y >= 0 && board.y <= 7)) // if move is within the 8x8 board
                {
                    if ((player.color[board.x, board.y]) != (player.color[board.x, board.y])) // if space isn't occupied by a piece of the same color or a piece of another color  
                    {
                        return true; //  move is valid
                    }
                    else
                    {
                        return false; // invalid move
                    }
                }
                else
                {
                    return false; // invalid move
                }
            }
        }
    }
}
