using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Ghost
    {
        //Variáveis de instância
        public ConsoleColor color;
        public Position position;
        public GhostState.EstadoDosFantasmas ghostState;

        //Método Construtor
        public Ghost(ConsoleColor color, Position position)
        {
            this.color = color;
            this.position = position;
            ghostState = GhostState.EstadoDosFantasmas.Inside;
        }




        public void Movement()
        {
            //Ask what ghost to move

            //What space to move to

            //MovementCondition(Ghost movingGhost, wantedPosition);

            //If space has a ghost already, call fight method

            //Else if space has a mirror, call mirrorMovement from Mirror class
            
            //Else, move ghost to wantedPosition
        }




        public void Fight(Ghost g1, Ghost g2, Position wantedPosition)
        {
            Ghost winner, loser;


            //Condições para o fantasma 1 ganhar
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


            //Condições para o fantasma 2 ganhar
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

            loser.ghostState = GhostState.EstadoDosFantasmas.Locked;
            loser.position = new Position(6, 6);
            winner.position = wantedPosition;

        }
    }
}