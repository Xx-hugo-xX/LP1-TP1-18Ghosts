using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Board
    {
        // Instance variables
        private roomState[,] state;
        public roomState currentTurn { get; private set;}

        // Class constructor
        public Board()
        {
            state = new roomState[5, 5];
            currentTurn = state.P1;
        }

        // Getter function for the "state" variable
        public roomState GetState(Position position)
        {
            return state[position.Row, position.Column];
        }

        // Setter function for the "state" variable
        public bool SetState(Position position, roomState newState)
        {
            // Defines new value for desired position and calls ChangeTurn()
            state[position.Row, position.Column] = newState;
            ChangeTurn();
            return true;
        }

        // Defines which player's turn it is to play.
        private void ChangeTurn()
        {
            // Changes the turn for the next player.
            if (currentTurn == roomState.P1) currentTurn = roomState.P2;
            else currentTurn = roomState.P1;
        }
    }
}
