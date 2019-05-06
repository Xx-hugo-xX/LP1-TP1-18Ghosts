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

        public State Check(Board board)
        {
            if (CheckForWin(ghost, State.P1)) return State.P1;
            if (CheckForWin(ghost, State.P2)) return State.P2;

            return State.Undecided; //Ainda niguem ganhou e o estado está 
            //undecided
        }


        public int CheckforWin(Player player)
        {
            Ghosts[] ghostRunAway = new Ghosts[9]; // creates a new array that 
                                                //saves the ghost who run away

            int runAwayCounter = 0;

            for (int i = 0; i < 9; i++)
            {
                GhostState state = player.ghostList[i].ghostState { get; };
                
                //adding to the array the ghosts 
                if (state == GhostState.Runaway) 
                {
                    ghostRunAway[runAwayCounter] = player.ghostList[i];
                    runAwayCounter++;
                }
            }


            if (Player(ghost, new Ghosts[]
            {
                new Out (3)
                return true;
            }
        }
    }
}