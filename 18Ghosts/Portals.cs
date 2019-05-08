using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Portals
    {
        // preciso 4 simbolo, mas e imprimido 1 de cada vez
        // precisa de uma cor
        // orientação é a casa para q esta a apontar
        //varios if
        char symbol;
        ConsoleColor color;
        Position orientation;

        //constructer method create a portal
        public Portals (char symbol, ConsoleColor color, Position position, Position orientation)
        {
            this.symbol = symbol;
            this.color = color;
            this.position = position;
            this.orientation = orientation;

        }

        public PortalRotation (Ghost ghost) //rotate the portals door
        {
             
        }

        public KickGhost (Ghost ghost) //send ghost to the out enum
        {

        }
    }

}
