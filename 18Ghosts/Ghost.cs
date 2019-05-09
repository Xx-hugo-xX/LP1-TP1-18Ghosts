using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Ghost
    {
        //Instance variables
        public string name { get; set; }
        public ConsoleColor color { get; }
        public Position position { get; set; }
        public GhostState ghostState { get; set; }

        //Constructer Method
        public Ghost(string name, ConsoleColor color, Position position)
        {
            this.name = name;
            this.color = color;
            this.position = position;
            ghostState = GhostState.Locked;
        }

        public void Fight(Ghost g1, Ghost g2, Position wantedPosition)
        {
            Ghost winner, loser;


            //Condition for the ghost g1 to win
            if(g1.color == ConsoleColor.Red &&
                g2.color == ConsoleColor.Blue)
            {
                winner = g1;
                loser = g2;
            }

            else if(g1.color == ConsoleColor.Blue &&
                g2.color == ConsoleColor.Yellow)
            {
                winner = g1;
                loser = g2;
            }

            else if(g1.color == ConsoleColor.Yellow &&
                g2.color == ConsoleColor.Red)
            {
                winner = g1;
                loser = g2;
            }


            //Condition for the ghost g2 to win
            else if (g2.color == ConsoleColor.Red &&
                g1.color == ConsoleColor.Blue)
            {
                winner = g2;
                loser = g1;
            }

            else if (g2.color == ConsoleColor.Blue &&
                g1.color == ConsoleColor.Yellow)
            {
                winner = g2;
                loser = g1;
            }

            else
            {
                winner = g2;
                loser = g1;
            }

            /*Set states and postions of the ghosts, based on
            who won and who lost */

            loser.ghostState = GhostState.Locked;
            loser.position = new Position(6, 6);
            winner.position = wantedPosition;

        }
    }
}