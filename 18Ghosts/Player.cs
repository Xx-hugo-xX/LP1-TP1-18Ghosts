using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Player
    {
        public Ghost[] ghostList { get; set; }

        public Player()
        {
            //Create and initialize an array of ghosts for each player
            Ghost[] ghostList = new Ghost[9];


            //Define every ghost a player has from the beginning
            Ghost r1 = new Ghost("r1", ConsoleColor.Red, new Position(0, 0));
            Ghost r2 = new Ghost("r2", ConsoleColor.Red, new Position(0, 0));
            Ghost r3 = new Ghost("r3", ConsoleColor.Red, new Position(0, 0));
            Ghost b1 = new Ghost("b1", ConsoleColor.Blue, new Position(0, 0));
            Ghost b2 = new Ghost("b2", ConsoleColor.Blue, new Position(0, 0));
            Ghost b3 = new Ghost("b3", ConsoleColor.Blue, new Position(0, 0));
            Ghost y1 = new Ghost("y1", ConsoleColor.Yellow, new Position(0, 0));
            Ghost y2 = new Ghost("y2", ConsoleColor.Yellow, new Position(0, 0));
            Ghost y3 = new Ghost("y3", ConsoleColor.Yellow, new Position(0, 0));

            //Add ghosts to the array
            ghostList[0] = r1;
            ghostList[1] = r2;
            ghostList[2] = r3;
            ghostList[3] = b1;
            ghostList[4] = b2;
            ghostList[5] = b3;
            ghostList[6] = y1;
            ghostList[7] = y2;
            ghostList[8] = y3;
        }
    }
}
