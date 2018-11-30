using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Knight
    {
        // board.x/y and player.color are just place holder names really until we decide something permenatly
        //spawn in class or do def? for spawns 
        //for movement will call from the chess board which is a an array with an x and y and add/subtract values from its current position to move
        //knights can jump over peices so dont have to worry about collisions just the end location
        public Knight()
        {
            Knight = new char[board.x, board.y] //knights current location
                //moves

                if (board.x == +2 && board.y == +1)//moves for knights
            {
                if (board.x >= 0 && board.x =< 7 && board.y =< 7 && board.y=>0)//checks if move is outside of the board
                {
                    if (player.color[board.x, board.y] != player.color[board.x, board.y])//checks to see if pieces are the same color or not
                    {
                        true;//if the prior if statements are met then this move is valid
                        //will overload the array to have this as the new piece here
                        //put an end turn here after the moves to switch players control of pieces?
                    }
                    else
                        false; //cannot do move, can replace this with errors if we want
                }
                else
                false;
            }//1

            else if (board.x == +2 && board.y == -1)
            {
                if (board.x >= 0 && board.x =< 7 && board.y =< 7 && board.y=>0)
                {
                    if (player.color[board.x, board.y] != player.color[board.x, board.y])
                    {
                        true;
                    }
                    else
                        false; 
                }
                else
                false;
            }//2

            else if (board.x == +1 && board.y == -2)
            {
                if (board.x >= 0 && board.x =< 7 && board.y =< 7 && board.y=>0)
                {
                    if (player.color[board.x, board.y] != player.color[board.x, board.y])
                    {
                        true;
                    }
                    else
                        false;
                }
                else
                false;
            }//3
            else if (board.x == +1 && board.y == +2)
            {
                if (board.x >= 0 && board.x =< 7 && board.y =< 7 && board.y=>0)
                {
                    if (player.color[board.x, board.y] != player.color[board.x, board.y])
                    {
                        true;
                    }
                    else
                        false;
                }
                else
                false;
            }//4
            else if (board.x == -2 && board.y == -1)
            {
                if (board.x >= 0 && board.x =< 7 && board.y =< 7 && board.y=>0)
                {
                    if (player.color[board.x, board.y] != player.color[board.x, board.y])
                    {
                        true;
                    }
                    else
                        false;
                }
                else
                false;
            }//5
            else if (board.x == -2 && board.y == +1)
            {
                if (board.x >= 0 && board.x =< 7 && board.y =< 7 && board.y=>0)
                {
                    if (player.color[board.x, board.y] != player.color[board.x, board.y])
                    {
                        true;
                    }
                    else
                        false;
                }
                else
                false;
            }//6
            else if (board.x == -1 && board.y == -2)
            {
                if (board.x >= 0 && board.x =< 7 && board.y =< 7 && board.y=>0)
                {
                    if (player.color[board.x, board.y] != player.color[board.x, board.y])
                    {
                        true;
                    }
                    else
                        false;
                }
                else
                false;
            }//7
            else if (board.x == -1 && board.y == +2)
            {
                if (board.x >= 0 && board.x =< 7 && board.y =< 7 && board.y=>0)
                {
                    if (player.color[board.x, board.y] != player.color[board.x, board.y])
                    {
                        true;
                    }
                    else
                        false;
                }
                else
                false;
            }//8

        }
    }
}
