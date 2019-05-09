using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class GameLoop
    {
        public void RunGameLoop(Board board, Render render, Player p1,
            Player p2, Movement movement, GhostRespawn ghostRespawn,
            CheckforWin checkforWin)
        {
            int option = 0;

            while (checkforWin.Check(p1, p2) == RoomState.Undecided)
            {
                // Print all display elements on screen
                render.Rendering(board, p1, p2);


                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 - Move");
                Console.WriteLine("2 - Rescue");

                while (option != 1 && option != 2)
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option != 1 && option != 2)
                        Console.WriteLine("Please select a valid option.");
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
                p1.UpdateLists();
                p2.UpdateLists();

                board.ChangeTurn();
            }
        }
    }
}
