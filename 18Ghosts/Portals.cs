﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    //Creates the portals and makes it possible for them to rotate
    class Portals
    {
        char symbol;
        ConsoleColor color;
        PortalState orientation;
        public Position portalPosition;
        public Position teleportPosition;

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
        public void PortalRotation (Ghost ghost) 
        {
            if (orientation == PortalState.North)
            {
                orientation = PortalState.East;
            }
            else if (orientation == PortalState.South)
            {
                orientation = PortalState.West;
            }
            else if (orientation == PortalState.West)
            {
                orientation = PortalState.North;
            }
            else if (orientation == PortalState.East)
            {
                orientation = PortalState.South;
            }
        }

        //send ghost to the out enum
        public void KickGhost (Player p1, Player p2) 
        {
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
