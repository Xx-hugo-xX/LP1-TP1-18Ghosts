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
            for (int i = 0; i < 9; i++)
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
                    Console.WriteLine("Please select a valid option.");
            }

            Ghost savedGhost = dungeonGhosts[option - 1];

            board.ChangeTurn();

            Console.WriteLine("Where does the adversary want to" +
                "put the ghost?");
            Console.WriteLine(" Space has to be free and the same" +
                "color as the ghost.");
            Console.WriteLine("Can't be a mirror or a portal (1-25)");

            
            bool validSpace = false;
            option = 0;
            Position wantedPosition;

            /* Opponent decides where he wants to put the ghost.
            Ghost is put in said position, if it is a valid one */
            while (validSpace == false)
            {
                option = Convert.ToInt32(Console.ReadLine());

                if (option < 1 || option > 25)
                {
                    wantedPosition = currentPlayer.PositionForNumber(option);
                    if (savedGhost.color == ConsoleColor.Red &&
                        board.type[wantedPosition.Row, wantedPosition.Column]
                        == RoomType.Red && board.state[wantedPosition.Row,
                        wantedPosition.Column] == RoomState.Undecided)
                    {
                        MakeChanges(currentPlayer, savedGhost, wantedPosition,
                            GhostState.Inside);
                        validSpace = true;
                    }
                    else if (savedGhost.color == ConsoleColor.Blue &&
                        board.type[wantedPosition.Row, wantedPosition.Column]
                        == RoomType.Blue && board.state[wantedPosition.Row,
                        wantedPosition.Column] == RoomState.Undecided)
                    {
                        MakeChanges(currentPlayer, savedGhost, wantedPosition,
                            GhostState.Inside);
                        validSpace = true;
                    }
                    else if (savedGhost.color == ConsoleColor.Yellow &&
                        board.type[wantedPosition.Row, wantedPosition.Column]
                        == RoomType.Yellow && board.state[wantedPosition.Row,
                        wantedPosition.Column] == RoomState.Undecided)
                    {
                        MakeChanges(currentPlayer, savedGhost, wantedPosition,
                            GhostState.Inside);
                        validSpace = true;
                    }
                    else Console.WriteLine("That position is unavailable.");
                }
                else Console.WriteLine("Please select a valid option.");
            }
            board.ChangeTurn();
        }

        //Change state and position of a ghost
        public void MakeChanges(Player currentPlayer, Ghost savedGhost,
            Position wantedPosition, GhostState wantedState)
        {
            for (int i = 0; i < 9; i++)
            {
                if (currentPlayer.ghostList[i].name == savedGhost.name)
                {
                    currentPlayer.ghostList[i].ghostState = wantedState;

                    currentPlayer.ghostList[i].position.Row
                        = wantedPosition.Row;

                    currentPlayer.ghostList[i].position.Column
                        = wantedPosition.Column;
                }
            }
        }

        // Fix later
        public bool IsThereGhostToRescue(Board board, Player player)
        {
            return true;
        }
    }
}
