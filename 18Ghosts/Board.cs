using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Board
    {
        public roomState CurrentTurn { get; private set;}

        // In this method, its defined wich player's turn it is to play
        private void ChangeTurn()
        {
            if (CurrentTurn == roomState.P1) CurrentTurn = roomState.P2;
            else CurrentTurn = roomState.P1;
        }
    }
}
