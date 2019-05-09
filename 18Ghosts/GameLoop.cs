using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class GameLoop
    {
        public void RunGameLoop(Board board, Render render, Player p1,
            Player p2, Movement movement, GhostRespawn ghostRespawn,
            CheckforWin checkforWin, Portals pRed, Portals pBlue,
            Portals pYellow, Ghost[] originalList)
        {
            p1.insideGhosts = p1.InsideGhostUpdate(originalList);
            p1.runawayGhosts = p1.RunawayGhostUpdate(originalList);
            p1.lockedGhosts = p1.LockedGhostUpdate(originalList);
            p2.insideGhosts = p2.InsideGhostUpdate(originalList);
            p2.runawayGhosts = p2.RunawayGhostUpdate(originalList);
            p2.lockedGhosts = p2.LockedGhostUpdate(originalList);



            while (checkforWin.Check(p1, p2) == RoomState.Undecided)
            {
                // Print all display elements on screen
                render.Rendering(board, p1, p2, pRed, pBlue, pYellow);

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 - Move");
                Console.WriteLine("2 - Rescue\n");

                int option = 0;

                while (option != 1 && option != 2)
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option != 1 && option != 2)
                        Console.WriteLine("Please select a valid option.");

                    if (board.currentTurn == RoomState.P1 && option == 2
                        && p1.lockedGhosts.Length == 0)
                    {
                        Console.WriteLine("You have no ghosts" +
                            " in the dungeon.");
                        Console.WriteLine("\nWhat do you want to do?");
                        Console.WriteLine("1 - Move");
                        Console.WriteLine("2 - Rescue");
                        option = 0;
                    }
                    if (board.currentTurn == RoomState.P2 && option == 2
                        && p2.lockedGhosts.Length == 0)
                    {
                        Console.WriteLine("You have no ghosts" +
                            " in the dungeon.");
                        Console.WriteLine("\nWhat do you want to do?");
                        Console.WriteLine("1 - Move");
                        Console.WriteLine("2 - Rescue");
                        option = 0;
                    }
                }

                if (option == 1)
                {
                    //movement function call
                }

                else
                {
                    if (board.currentTurn == RoomState.P1)
                    {
                        if (ghostRespawn.IsThereGhostToRescue(board, p1)
                            == true)
                            ghostRespawn.Respawn(board, p1, p2);
                    }
                    else
                    {
                        if (ghostRespawn.IsThereGhostToRescue(board, p2)
                            == true)
                            ghostRespawn.Respawn(board, p2, p1);
                    }
                }
                board.ChangeTurn();
            }
        }
    }
}
