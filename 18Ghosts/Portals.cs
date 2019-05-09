using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    //Creates the portals and makes it possible for them to rotate
    class Portals
    {
        public char symbol;
        public ConsoleColor color;
        public PortalState orientation;
        public Position portalPosition;

        //constructer method create a portal
        public Portals (char symbol, ConsoleColor color, Position position,
            PortalState orientation)
        {
            this.symbol = symbol;
            this.color = color;
            portalPosition = position;
            this.orientation = orientation;

        }

        //rotate the portals door
        public Portals PortalRotation () 
        {
            if (orientation == PortalState.North)
            {
                orientation = PortalState.East;
                symbol = '\u2191';
            }
            else if (orientation == PortalState.South)
            {
                orientation = PortalState.West;
                symbol = '\u2190';

            }
            else if (orientation == PortalState.West)
            {
                orientation = PortalState.North;
                symbol = '\u2192';

            }
            else if (orientation == PortalState.East)
            {
                orientation = PortalState.South;
                symbol = '\u2193';

            }
            return this; 
        }

        public Position DefTeleportPosition()
        {
            Position teleportPosition = new Position(0,0);

            if (orientation == PortalState.North)
            {
                teleportPosition.Row = portalPosition.Row - 1;
                teleportPosition.Column = portalPosition.Column;
            }
            else if (orientation == PortalState.South)
            {
                teleportPosition.Row = portalPosition.Row + 1;
                teleportPosition.Column = portalPosition.Column;
            }
            else if (orientation == PortalState.West)
            {
                teleportPosition.Row = portalPosition.Row;
                teleportPosition.Column = portalPosition.Column - 1;
            }
            else if (orientation == PortalState.East)
            {
                teleportPosition.Row = portalPosition.Row;
                teleportPosition.Column = portalPosition.Column + 1;
            }
            return teleportPosition;
        }

        //send ghost to the out enum
        public void KickGhost (Player p1, Player p2) 
        {
            Position teleportPosition = DefTeleportPosition();

            for (int i = 0; i < 9; i++)
            {
                if (p1.ghostList[i].position.Row == teleportPosition.Row &&
                    p1.ghostList[i].position.Column == teleportPosition.Column)
                {
                    p1.ghostList[i].ghostState = GhostState.Runaway;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                if (p2.ghostList[i].position.Row == teleportPosition.Row &&
                    p2.ghostList[i].position.Column == teleportPosition.Column)
                {
                    p2.ghostList[i].ghostState = GhostState.Runaway;
                }
            }
        }
    }

}
