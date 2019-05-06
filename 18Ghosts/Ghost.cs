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

        public void Fight(Ghost g1, Ghost g2)
        {

        }


    }
}
