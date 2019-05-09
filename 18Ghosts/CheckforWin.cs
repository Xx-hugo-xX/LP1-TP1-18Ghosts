using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    //Checks if a player can win the game
    class CheckforWin
    {
        public RoomState Check(Player p1, Player p2 )
        {
            if (CheckForWin(p1)) return RoomState.P1;
            if (CheckForWin(p2)) return RoomState.P2;
            else return RoomState.Undecided;
        }

        //Checks the Color
        public bool CheckForWin(Player player)
        {
            bool won = false;

            //verifying color 
            bool redOut = false;
            bool blueOut = false;
            bool yellowOut = false;

            for (int i = 0; i < player.runawayGhosts.Length; i++)
            {
                if (player.runawayGhosts[i].color == ConsoleColor.Red)
                {
                    redOut = true;
                   
                }
                else if (player.runawayGhosts[i].color == ConsoleColor.Blue)
                {
                    blueOut = true;
                }
                else if (player.runawayGhosts[i].color == ConsoleColor.Yellow)
                {
                    yellowOut = true;
                }
            }
            if (redOut == true && blueOut == true && yellowOut == true)
            {
                won = true;
            }
            return won;
        }
    }
}