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


        public bool CheckforWin(State, ghost)
        {
            // se no stat ghosts, 3 estiverem no estado out então o 
            //jogador ganha
            if (State(ghost, new Out[]
            {
                new Out (3)
                return true;
            }
        }
    }
}