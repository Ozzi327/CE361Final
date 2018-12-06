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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Pawn_class
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public class pawn
    {
        pawn = new char[board.x, board.y]; //checks location of the pawn
            
            private void pawnmove()
            {
            int n;
            int m;
            m = pawn[board.y];
            n = pawn[board.x];
            if (player.color == 0) //checks to see which player is moving based on color?
            {
                if (pawn[board.y] == 1)//checks to see if the pawn is in its starting position and if it is allows it to move two spaces
                {
                    if (pawn[board.y == +2])
                    {
                        if (space[board.x == n, board.y == 2] && space[board.x == n, board.y == 3])//checks to see if anypiece is in its way
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }

                    }
                    if (board.x == +1 && board.y == +1)//pawns attacking move 
                    {
                        if (player.color[board.x, board.y] == 1)//only works if an enemy piece is there
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                    }
                    if (board.x == -1 && board.y == +1)//pawns attacking move 
                    {
                        if (player.color[board.x, board.y] == 1)//only works if an enemy piece is there
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                    }
                    if (pawn[board.y == +1])
                    {
                        if (space[board.x == n, board.y == m])
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                    }

                }
                else
                {
                    if (board.x == +1 && board.y == +1)//pawns attacking move 
                    {
                        if (player.color[board.x, board.y] == 1)//only works if an enemy piece is there
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                    }
                    if (board.x == -1 && board.y == +1)//pawns attacking move 
                    {
                        if (player.color[board.x, board.y] == 1)//only works if an enemy piece is there
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                        if (pawn[board.y == +1])
                        {
                            if (space[board.x == n, board.y == m])
                            {
                                true;
                            }
                            else
                            {
                                false;
                            }
                        }

                    }
                }
            }
            else if (player.color == 1) //checks to see which player is moving based on color?
            {
                if (pawn[board.y] == 6)//checks to see if the pawn is in its starting position and if it is allows it to move two spaces
                {
                    if (pawn[board.y == -2])
                    {
                        if (space[board.x == n, board.y == 5] && space[board.x == n, board.y == 4])//checks to see if anypiece is in its way
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }

                    }
                    if (board.x == +1 && board.y == -1)//pawns attacking move 
                    {
                        if (player.color[board.x, board.y] == 1)//only works if an enemy piece is there
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                    }
                    if (board.x == -1 && board.y == -1)//pawns attacking move 
                    {
                        if (player.color[board.x, board.y] == 1)//only works if an enemy piece is there
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                    }
                    if (pawn[board.y == -1])
                    {
                        if (space[board.x == n, board.y == m])
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                    }

                }
                else
                {
                    if (board.x == +1 && board.y == -1)//pawns attacking move 
                    {
                        if (player.color[board.x, board.y] == 1)//only works if an enemy piece is there
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                    }
                    if (board.x == -1 && board.y == -1)//pawns attacking move 
                    {
                        if (player.color[board.x, board.y] == 1)//only works if an enemy piece is there
                        {
                            true;
                        }
                        else
                        {
                            false;
                        }
                        if (pawn[board.y == -1])
                        {
                            if (space[board.x == n, board.y == m])
                            {
                                true;
                            }
                            else
                            {
                                false;
                            }
                        }

                    }
                }
            }

        }
    }
}
