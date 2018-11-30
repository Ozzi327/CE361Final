using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Jonathan Tran
/// 819325761   
/// not working code at all 
/// have to see what will happen with the board class and how that will interact with
/// the pieces
/// </summary>
namespace Rook
{
    public class Rook
    {
        
         Rook = new char[board.x, board.y];//location of the rook
         
            
            public Rook()
            {
                
            }
            /// <summary>
            /// movement of the rook 
            /// checks for validity of the move
            /// </summary>
             private void rkMOVE()
             {
             if (board.x <= 7 || board.y <= 7) //moves the rook --> can go straight in either x or y plane
                 {
                     //will only continue if the move is possible
                     if ((board.x >= 0) && (board.x <= 7) && (board.y =< 7) && (board.y >= 0))
                     {
                         if (player.color[board.x, board.y] != player.color[board.x, board.y])
                         {
                             move = true;
                             // cannot move to this place if there is another of your piece already there
                             // would probably have to see if there are others in front of it as well though
                         }
                         else
                             move = false; //cannot move to a place with a piece there
                     }
                     else
                         move = false; //cannot move out of bounds
                 }
                 else
                    move = false; //cannot move beyond the bounds of the rook's movement
             }
        
    }
}
