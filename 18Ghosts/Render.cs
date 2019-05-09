using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Render
    {
        public void Rendering(Board board, Player p1, Player p2, Portals pRed, Portals pBlue, Portals pYellow)
        {
            ActvGhosts(p1, p2);
            CapturedGhosts(p1, p2);
            EscapedGhosts(p1, p2);
            PlayerTurn(board);
            BattleRules();
            DrawMap(board, p1, p2, pRed, pBlue, pYellow);
        }
        // Method that shows the number of active Ghosts for both Players
        //(Ghosts in the board).
        public void ActvGhosts(Player p1, Player p2)
        {

            Console.WriteLine("Roaming Ghosts:");
            //Shows the number of Player1's active Ghosts.
            Console.Write("P1 - ");
            for (int i = 0; i < p1.insideGhosts.Length; i++)
            {
                if (i == (p1.insideGhosts.Length -1))
                {
                    Console.Write($"{p1.insideGhosts[i].name}.");
                }
                else
                {
                    Console.Write($"{p1.insideGhosts[i].name}, ");
                }
            }
            Console.Write("\nP2 - ");
            for (int i = 0; i < p2.insideGhosts.Length; i++)
            {
                if (i == (p2.insideGhosts.Length - 1))
                {
                    Console.Write($"{p2.insideGhosts[i].name}.");
                }
                else
                {
                    Console.Write($"{p2.insideGhosts[i].name}, ");
                }
            }


        }

        // Method that shows the number of both Players captured Ghosts (Ghosts
        //in the catacombs).
        public void CapturedGhosts(Player p1, Player p2)
        {

            Console.WriteLine("\n\nTrapped Ghosts:");
            //Shows the number of Player1's active Ghosts.
            Console.Write("P1 - ");
            for (int i = 0; i < p1.lockedGhosts.Length; i++)
            {
                if (i == (p1.lockedGhosts.Length - 1))
                {
                    Console.Write($"{p1.lockedGhosts[i].name}.");
                }
                else
                {
                    Console.Write($"{p1.lockedGhosts[i].name}, ");
                }
            }
            Console.Write("\nP2 - ");
            for (int i = 0; i < p2.lockedGhosts.Length; i++)
            {
                if (i == (p2.lockedGhosts.Length - 1))
                {
                    Console.Write($"{p2.lockedGhosts[i].name}.");
                }
                else
                {
                    Console.Write($"{p2.lockedGhosts[i].name}, ");
                }
            }

        }

        public void EscapedGhosts(Player p1, Player p2)
        {

            Console.WriteLine("\n\nEscaped Ghosts:");
            //Shows the number of Player1's active Ghosts.
            Console.Write("P1 - ");
            for (int i = 0; i < p1.runawayGhosts.Length; i++)
            {
                if (i == (p1.runawayGhosts.Length - 1))
                {
                    Console.Write($"{p1.runawayGhosts[i].name}.");
                }
                else
                {
                    Console.Write($"{p1.runawayGhosts[i].name}, ");
                }
            }
            Console.Write("\nP2 - ");
            for (int i = 0; i < p2.runawayGhosts.Length; i++)
            {
                if (i == (p2.runawayGhosts.Length - 1))
                {
                    Console.Write($"{p2.runawayGhosts[i].name}.");
                }
                else
                {
                    Console.Write($"{p2.runawayGhosts[i].name}, ");
                }
            }
        }

        // Method that shows who's Players turn it is to play.
        public void PlayerTurn(Board board)
        {
            //Shows wich Player's turn it is to play.
            Console.Write($"\n\nTurn: {board.currentTurn}");
        }

        // Method that shows the players which Ghost (color) is superior to
        //which in combat.
        public void BattleRules()
        {
            Console.Write("  |  Red -> Blue; Blue -> Yellow; Yellow -> Red\n");
        }


        // Method that draws the map and Player's Ghosts.
        public void DrawMap(Board board, Player p1, Player p2, Portals pRed,
            Portals pBlue, Portals pYellow)
        {
            int rows = 5;
            int columns = 5;
            int lines = 7;
            int space = 0;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        space = i * 5 + k;

                        switch (j)
                        {
                            //This row defines the top limit of the map grid. 
                            case 0:
                                Console.Write("+-------------");
                                if (space == 4 || space == 9 || space == 14 || 
                                    space == 19 || space == 24)
                                {
                                    Console.Write("+");
                                }
                                break;

                            /*In this case (1), the number of the room is 
                            shown. This Appears in the top left corner of
                            the room. */
                            case 1:
                                Console.Write("|");
                                //This specific condition deals with house 
                                //numbers below 10 (having the correct number
                                //õf spaces).
                                if ((space + 1) < 10)
                                {
                                    Console.Write($"{space + 1}          " +
                                        $"  ");
                                }
                                //This specific condition deals with house 
                                //numbers from and above 10 (having the correct
                                //number of spaces).
                                else
                                {
                                    Console.Write($"{space + 1}          " +
                                        $" ");
                                }
                                //This condition specificly draws the division
                                //between the diferent houses.
                                if (space == 4 || space == 9 || space == 14 ||
                                 space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            case 2:
                                Console.Write("|");
                                if (board.type[i, k] == RoomType.Red)
                                    Console.BackgroundColor = ConsoleColor.Red;
                                else if (board.type[i, k] ==
                                    RoomType.Blue)
                                    Console.BackgroundColor =
                                        ConsoleColor.Blue;
                                else if (board.type[i, k] ==
                                    RoomType.Yellow)
                                    Console.BackgroundColor =
                                        ConsoleColor.Yellow;
                                Console.Write("             ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            case 3: 
                                if (board.state[i, k] == RoomState.P1)
                                    Console.Write("|      P1     ");
                                else if (board.state[i, k] == RoomState.P2)
                                    Console.Write("|      P2     ");
                                else
                                    Console.Write("|             ");

                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            case 4:
                                Console.Write("|");
                                if (space == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write($"      {pRed.symbol}    " +
                                        $"  ");
                                    Console.ForegroundColor = ConsoleColor.
                                        White;
                                }
                                else if (space == 14)
                                {
                                    Console.ForegroundColor = ConsoleColor.
                                        Yellow;
                                    Console.Write($"      {pYellow.symbol}   " +
                                        $"   ");
                                    Console.ForegroundColor = ConsoleColor.
                                        White;
                                }
                                else if (space == 22)
                                {
                                    Console.ForegroundColor = ConsoleColor.
                                        Blue;
                                    Console.Write($"      {pBlue.symbol}   " +
                                        $"   ");
                                    Console.ForegroundColor = ConsoleColor.
                                        White;
                                }

                                else
                                    Console.Write("             ");



                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            case 5:
                                if (board.state[i, k] == RoomState.P1)
                                {
                                    for (int l = 0; l < p1.insideGhosts.Length;
                                    l++)
                                    {
                                        if (p1.insideGhosts[l].position.Row== i
                                            && p1.insideGhosts[l].position.
                                            Column == k)
                                        {
                                            Console.Write($"|" +
                                                $"      {p1.insideGhosts[l].name}" +
                                                $"     ");
                                        }
                                    }
                                }
                                else if (board.state[i, k] == RoomState.P2)
                                {
                                    for (int l = 0; l < p2.insideGhosts.Length;
                                    l++)
                                    {
                                        if (p2.insideGhosts[l].position.Row == i
                                            && p2.insideGhosts[l].position.
                                            Column == k)
                                        {
                                            Console.Write($"|" +
                                                $"      {p2.insideGhosts[l].name}" +
                                                $"     ");
                                        }
                                    }
                                }
                                

                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            case 6:
                                Console.Write("|             ");
                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;


                        }
                    }
                    Console.Write("\n");
                }

            }
            Console.Write("+-------------+-------------+-------------+" +
            "-------------+-------------+\n\n");
        }
    }
}
