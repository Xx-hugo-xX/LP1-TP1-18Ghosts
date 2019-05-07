using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class WinningCondition
    {
        //se jogo estiver no modo fast tem o jogador tem de eliminar 3 fantasmas
        //public void modo (string[] args)
        // {
        // if jogo == fast //criar fast
        // {
        //     Check();
        // }
        //}

        public RoomState Check(Player p1, Player p2 )
        {
            if (CheckForWin(p1)) return RoomState.P1;
            if (CheckForWin(p2)) return RoomState.P2;

            return RoomState.Undecided; //Ainda niguem ganhou e o estado está 
            //undecided
        }


        public bool CheckForWin(Player player)
        {
            bool won = false;
            
            Ghost[] ghostRunAway = new Ghost[9]; // creates a new array that 
                                                //saves the ghost who run away

            int runAwayCounter = 0;

            for (int i = 0; i < 9; i++)
            {
                GhostState state = player.ghostList[i].ghostState;
                
                //adding to the array the ghosts 
                if (state == GhostState.Runaway) 
                {
                    ghostRunAway[runAwayCounter] = player.ghostList[i];
                    runAwayCounter++;
                }
            }

            //verifying color 
            bool redOut = false;
            bool blueOut = false;
            bool yellowOut = false;

        }
    }
}