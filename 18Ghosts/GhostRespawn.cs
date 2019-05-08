using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class GhostRespawn
    {
        public void Respawn(Player currentPlayer, Player adversary)
        {
            int dungeonCounter = 0;

            for (int i = 0; i < 9; i++)
            {
                if (currentPlayer.ghostList[i].ghostState == GhostState.Locked)
                    dungeonCounter++;
            }

            Ghost[] dungeonGhosts = new Ghost[dungeonCounter];
            int adding = 0;

            for (int i = 0; i < dungeonCounter; i++)
            {
                if (currentPlayer.ghostList[i].ghostState == GhostState.Locked)
                {
                    dungeonGhosts[adding] = currentPlayer.ghostList[i];
                    adding++;
                }
            }

        }
    }
}
