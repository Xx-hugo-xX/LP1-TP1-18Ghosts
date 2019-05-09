using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Setup
    {
        public void SetPlayerSpaces(Board board, Player p1, Player p2)
        {
            board.currentTurn = RoomState.P1;
            DefinePosition(board, p1);
            board.ChangeTurn();
            DefinePosition(board, p2);
            DefinePosition(board, p2);
            board.ChangeTurn();
            DefinePosition(board, p1);
            board.ChangeTurn();
            DefinePosition(board, p2);
            board.ChangeTurn();
            DefinePosition(board, p1);
            board.ChangeTurn();
            DefinePosition(board, p2);
            board.ChangeTurn();
            DefinePosition(board, p1);
            board.ChangeTurn();
            DefinePosition(board, p2);
            board.ChangeTurn();
            DefinePosition(board, p1);
            board.ChangeTurn();
            DefinePosition(board, p2);
            board.ChangeTurn();
            DefinePosition(board, p1);
            board.ChangeTurn();
            DefinePosition(board, p2);
            board.ChangeTurn();
            DefinePosition(board, p1);
            board.ChangeTurn();
            DefinePosition(board, p2);
            board.ChangeTurn();
            DefinePosition(board, p1);
            board.ChangeTurn();
            DefinePosition(board, p2);
            board.ChangeTurn();
            DefinePosition(board, p1);


        }

        public void DefinePosition(Board board, Player player)
        {
            Console.WriteLine("Qual fantasma quer colocar no tabuleiro?"); 
            for (int i = 0; i < player.lockedGhosts.Length; i++)
            {
                Console.WriteLine($"{i+1} - {player.lockedGhosts[i].name}");
            }
            bool choseSpace = false;
            while (choseSpace == false)
            {
                int option = 0;

                while (option < 1 || option > player.lockedGhosts.Length)
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option < 1 || option > player.lockedGhosts.Length)
                        Console.WriteLine("Please select a valid option.");
                }
                Ghost selectedGhost = player.lockedGhosts[option - 1];

                Position coordinates = player.GetPosition(board);

                if (board.state[coordinates.Row, coordinates.Column]
                    == RoomState.Undecided)
                {
                    for (int i = 0; i < player.lockedGhosts.Length; i++)
                    {
                        if (player.lockedGhosts[i].name == selectedGhost.name)
                        {
                            if (board.type[coordinates.Row,
                                coordinates.Column] == RoomType.Red)
                            {
                                if (player.lockedGhosts[i].color
                                    == ConsoleColor.Red)
                                {
                                    player.lockedGhosts[i].position
                                        = coordinates;
                                    if (board.currentTurn == RoomState.P1)
                                        board.state[coordinates.Row,
                                            coordinates.Column] = RoomState.P1;
                                    else if (board.currentTurn == RoomState.P2)
                                        board.state[coordinates.Row,
                                            coordinates.Column] =
                                            RoomState.P2;
                                    choseSpace = true;
                                }

                            }
                            else if (board.type[coordinates.Row,
                                coordinates.Column] == RoomType.Blue)
                            {
                                if (player.lockedGhosts[i].color
                                    == ConsoleColor.Blue)
                                {
                                    player.lockedGhosts[i].position
                                        = coordinates;
                                    if (board.currentTurn == RoomState.P1)
                                        board.state[coordinates.Row,
                                            coordinates.Column] = RoomState.P1;
                                    else if (board.currentTurn == RoomState.P2)
                                        board.state[coordinates.Row,
                                            coordinates.Column] =
                                            RoomState.P2;
                                    choseSpace = true;
                                }
                            }
                            else if (board.type[coordinates.Row,
                                coordinates.Column] == RoomType.Yellow)
                            {
                                if (player.lockedGhosts[i].color
                                    == ConsoleColor.Yellow)
                                {
                                    player.lockedGhosts[i].position
                                        = coordinates;
                                    if (board.currentTurn == RoomState.P1)
                                        board.state[coordinates.Row,
                                            coordinates.Column] = RoomState.P1;
                                    else if (board.currentTurn == RoomState.P2)
                                            board.state[coordinates.Row,
                                                coordinates.Column] =
                                                RoomState.P2;
                                    choseSpace = true;
                                }
                            }
                        }
                    }
                }
                if (choseSpace == false)
                    Console.WriteLine("Position not available.");
            }
        }
    }
}
