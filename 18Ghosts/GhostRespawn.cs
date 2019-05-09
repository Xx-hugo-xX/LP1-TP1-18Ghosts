using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class GhostRespawn
    {
        public void Respawn(Board board, Player currentPlayer, Player adversary)
        {
            int dungeonCounter = 0;


            // Gets how many ghosts have "Locked" state
            for (int i = 0; i < 9; i++)
            {
                if (currentPlayer.ghostList[i].ghostState == GhostState.Locked)
                    dungeonCounter++;
            }

            Ghost[] dungeonGhosts = new Ghost[dungeonCounter];
            int adding = 0;


            /* Loops players ghostList and adds all ghosts that have "Locked"
            state to dungeonGhosts list */
            for (int i = 0; i < dungeonCounter; i++)
            {
                if (currentPlayer.ghostList[i].ghostState == GhostState.Locked)
                {
                    dungeonGhosts[adding] = currentPlayer.ghostList[i];
                    adding++;
                }
            }


            Console.WriteLine("What ghost do you want to save?");
            for (int i = 0; i < dungeonCounter; i++)
            {
                Console.WriteLine($"{i+1} - {dungeonGhosts[i].name}");
            }

            int option = 0;

            while (option < 1 || option > dungeonCounter)
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option < 1 || option > dungeonCounter)
                    Console.WriteLine("Please input a valid answer.");
            }

            Ghost savedGhost = dungeonGhosts[option - 1];

            board.ChangeTurn();

            Console.WriteLine("Where does the adversary want to" +
                "put the ghost? (1-25)");

            bool validSpace = false;
            option = 0;
            Position wantedPosition;

            while (validSpace == false)
            {
                option = Convert.ToInt32(Console.ReadLine());

                if (option < 1 || option > 25)
                {
                    wantedPosition = currentPlayer.PositionForNumber(option);
                    if (true)
                    {

                    }
                }
            }
        }
    }
}
