using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class GhostRespawn
    {
        public void Respawn(Board board, Player currentPlayer,
            Player adversary)
        {
            Console.WriteLine("What ghost do you want to save?");
            for (int i = 0; i < currentPlayer.lockedGhosts.Length; i++)
            {
                Console.WriteLine($"{i+1} -" +
                    $"{currentPlayer.lockedGhosts[i].name}");
            }

            int option = 0;

            while (option < 1 || option > currentPlayer.lockedGhosts.Length)
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option < 1 || option > currentPlayer.lockedGhosts.Length)
                    Console.WriteLine("Please select a valid option.");
            }

            Ghost savedGhost = currentPlayer.lockedGhosts[option - 1];

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
