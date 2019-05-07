using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Board
    {
        private roomState[,] state;
        public roomState currentTurn { get; private set;}

        public Board()
        {
            state = new roomState[5, 5];
            currentTurn = state.P1;
        }

        // In this method, its defined wich player's turn it is to play
        private void ChangeTurn()
        {
            if (currentTurn == roomState.P1) currentTurn = roomState.P2;
            else currentTurn = roomState.P1;
        }
    }
}
