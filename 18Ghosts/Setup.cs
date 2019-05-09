using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Setup
    {
        public void SetPlayerSpaces(Render render, Board board, Player p1,
            Player p2, Portals pRed, Portals pBlue, Portals pYellow,
            Ghost[] insideGhosts, Ghost[] runawayGhosts, Ghost[] lockedGhosts, Ghost[] ghostList)
        {
            board.currentTurn = RoomState.P1;
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);
            DefinePosition(board, p1, ref insideGhosts,  runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);
           
            DefinePosition(board, p1, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p1, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p1, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p1, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p1, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p1, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p1, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p2, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);
            board.ChangeTurn();
            render.Rendering(board, p1, p2, pRed, pBlue, pYellow);


            DefinePosition(board, p1, ref insideGhosts, runawayGhosts, lockedGhosts, ghostList);


        }

        public void DefinePosition(Board board, Player player,
            ref Ghost[] insideGhosts, Ghost[] runawayGhosts,
            Ghost[] lockedGhosts, Ghost[] originalList)
        {

           

            bool choseSpace = false;

            Console.WriteLine("Which ghost do you want to move?");
            for (int i = 0; i < player.lockedGhosts.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {player.lockedGhosts[i].name}");
            }

            while (choseSpace == false)
            {
                int option = 0;

                while (option < 1 || option > player.lockedGhosts.Length)
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option < 1 || option > player.lockedGhosts.Length)
                        Console.WriteLine("Please select a valid option.");
                }
                Position coordinates = player.GetPosition(board);

                if (board.state[coordinates.Row, coordinates.Column]
                    == RoomState.Undecided)
                {
                    if (player.lockedGhosts[option - 1].color
                        == ConsoleColor.Red && board.type[coordinates.Row,
                        coordinates.Column] == RoomType.Red)
                    {
                        player.lockedGhosts[option - 1].position = coordinates;
                        player.lockedGhosts[option - 1].ghostState = GhostState.Inside;

                        if (board.currentTurn == RoomState.P1)
                        {
                            board.state[coordinates.Row,
                            coordinates.Column] = RoomState.P1;
                        }
                        else if (board.currentTurn == RoomState.P2)
                        {
                            board.state[coordinates.Row,
                            coordinates.Column] = RoomState.P2;
                        }
                        choseSpace = true;
                    }

                    else if (player.lockedGhosts[option - 1].color == ConsoleColor.Blue && board.type[coordinates.Row, coordinates.Column] == RoomType.Blue)
                    {
                        player.lockedGhosts[option - 1].position = coordinates;
                        player.lockedGhosts[option - 1].ghostState = GhostState.Inside;
                        if (board.currentTurn == RoomState.P1)
                        {
                            board.state[coordinates.Row,
                            coordinates.Column] = RoomState.P1;
                        }
                        else if (board.currentTurn == RoomState.P2)
                        {
                            board.state[coordinates.Row,
                            coordinates.Column] = RoomState.P2;
                        }
                        choseSpace = true;
                    }
                    else if (player.lockedGhosts[option - 1].color == ConsoleColor.Yellow && board.type[coordinates.Row, coordinates.Column] == RoomType.Yellow)
                    {
                        player.lockedGhosts[option - 1].position = coordinates;
                        player.lockedGhosts[option - 1].ghostState = GhostState.Inside;
                        if (board.currentTurn == RoomState.P1)
                        {
                            board.state[coordinates.Row,
                            coordinates.Column] = RoomState.P1;
                        }
                        else if (board.currentTurn == RoomState.P2)
                        {
                            board.state[coordinates.Row,
                            coordinates.Column] = RoomState.P2;
                        }
                        choseSpace = true;
                    }

                }
                if (choseSpace == false)
                    Console.WriteLine("Position not available.");

                player.insideGhosts = player.InsideGhostUpdate(originalList);
                player.runawayGhosts = player.RunawayGhostUpdate(originalList);
                player.lockedGhosts = player.LockedGhostUpdate(originalList);
            }
        }
    }
}
                
