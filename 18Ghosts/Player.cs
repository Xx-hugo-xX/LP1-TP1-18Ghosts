using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Player
    {
        public Ghosts[] ghostList;

        public Ghosts r1 = new Ghosts(ConsoleColor.Red, new Position(0, 0));
        public Ghosts r2 = new Ghosts(ConsoleColor.Red, new Position(0, 0));
        public Ghosts r3 = new Ghosts(ConsoleColor.Red, new Position(0, 0));
        public Ghosts b1 = new Ghosts(ConsoleColor.Blue, new Position(0, 0));
        public Ghosts b2 = new Ghosts(ConsoleColor.Blue, new Position(0, 0));
        public Ghosts b3 = new Ghosts(ConsoleColor.Blue, new Position(0, 0));
        public Ghosts y1 = new Ghosts(ConsoleColor.Yellow, new Position(0, 0));
        public Ghosts y2 = new Ghosts(ConsoleColor.Yellow, new Position(0, 0));
        public Ghosts y3 = new Ghosts(ConsoleColor.Yellow, new Position(0, 0));

    }
}
