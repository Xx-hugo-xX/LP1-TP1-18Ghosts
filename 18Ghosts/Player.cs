using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Player
    {
        public Ghost[] ghostList;

        public Ghost r1 = new Ghost(ConsoleColor.Red, new Position(0, 0));
        public Ghost r2 = new Ghost(ConsoleColor.Red, new Position(0, 0));
        public Ghost r3 = new Ghost(ConsoleColor.Red, new Position(0, 0));
        public Ghost b1 = new Ghost(ConsoleColor.Blue, new Position(0, 0));
        public Ghost b2 = new Ghost(ConsoleColor.Blue, new Position(0, 0));
        public Ghost b3 = new Ghost(ConsoleColor.Blue, new Position(0, 0));
        public Ghost y1 = new Ghost(ConsoleColor.Yellow, new Position(0, 0));
        public Ghost y2 = new Ghost(ConsoleColor.Yellow, new Position(0, 0));
        public Ghost y3 = new Ghost(ConsoleColor.Yellow, new Position(0, 0));


        public void movement()
        {
            //MovementCondition();


        }

    }
}
