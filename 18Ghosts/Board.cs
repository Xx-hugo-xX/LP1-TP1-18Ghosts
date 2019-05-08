using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Board
    {
        // Instance variables
        public RoomState[,] state;
        public RoomType[,] type;
        public Position[,,] coordinates;
        public RoomState currentTurn { get; private set;}

        // Class constructor
        public Board()
        {
            state = new RoomState[5, 5];
         
            
            /*
            type = new RoomType[5, 5] {{RoomType.Blue, RoomType.Red,
                    RoomType.Portal, RoomType.Blue, RoomType.Red},
                    { RoomType.Yellow, RoomType.Mirror, RoomType.Yellow,
                    RoomType.Mirror, RoomType.Yellow},
                    { RoomType.Red, RoomType.Blue, RoomType.Red,
                    RoomType.Blue, RoomType.Portal},
                    { RoomType.Blue, RoomType.Mirror, RoomType.Yellow,
                    RoomType.Mirror, RoomType.Red},
                    { RoomType.Yellow, RoomType.Red, RoomType.Portal,
                    RoomType.Blue, RoomType.Yellow}}; 
                */


            coordinates = new Position[5, 5, 4];
            currentTurn = RoomState.P1;
        }



        // Getter function for the "state" variable
        public RoomState GetState(Position position)
        {
            return state[position.Row, position.Column];
        }

        // Setter function for the "state" variable
        public bool SetState(Position position, RoomState newState)
        {
            // Defines new value for desired position and calls ChangeTurn()
            state[position.Row, position.Column] = newState;
            ChangeTurn();
            return true;
        }

        // Defines which player's turn it is to play.
        public void ChangeTurn()
        {
            // Changes the turn for the next player.
            if (currentTurn == RoomState.P1) currentTurn = RoomState.P2;
            else currentTurn = RoomState.P1;
        }

        /*public Position GetCoordinate(Position playerPosition)
        {


        }
        */
       


    }
}
