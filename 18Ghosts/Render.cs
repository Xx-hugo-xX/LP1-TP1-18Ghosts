using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Render
    {

        // Method that shows the number of active Ghosts for both Players
        //(Ghosts in the board).
        private void ActvGhosts(Player p1, Player p2)
        {

            Console.WriteLine("Active Ghosts:");
            //Shows the number of Player1's active Ghosts.
            Console.WriteLine($"Player1: R({}) / Y({}) / B({})");
            //Shows the number of Player2's active Ghosts.
            Console.WriteLine($"Player2: R({}) / Y({}) / B({})");

        }

        // Method that shows the number of both Players captured Ghosts (Ghosts
        //in the catacombs).
        private void CapturedGhosts(Player p1, Player p2)
        {

            Console.WriteLine("Active Ghosts:");
            //Shows the number of Player1's captured Ghosts.
            Console.WriteLine($"Player1: R({}) / Y({}) / B({})");
            //Shows the number of Player2's captured Ghosts.
            Console.WriteLine($"Player2: R({}) / Y({}) / B({})");

        }

        // Method that shows who's Players turn it is to play.
        private void PlayerTurn()
        {
            //Shows wich Player's turn it is to play.
            Console.WriteLine($"Turn: {}");
        }

        // Method that shows the players which Ghost (color) is superior to
        //which in combat.
        private void BattleRules()
        {
            Console.WriteLine("R -> B -> Y -> R");
        }

        //UNICODE
        //poderao dar jeito os seguintes símbolos:
        // U+142F
        // U+1431
        // U+1433
        // U+1438

        // Method that draws the map and Player's Ghosts.
        private void DrawMap()
        {
            int rows = 5;
            int columns = 5;
            int lines = 9;
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
                                Console.Write("+----------------");
                                if (space == 4 || space == 9 || space == 14 || 
                                    space == 19 || space == 24)
                                {
                                    Console.Write("+");
                                }
                                break;

                            //In this case (1), the number of the room is 
                            //shown. This Appears in the top left corner of
                            //the room.
                            case 1:
                                Console.Write("|");
                                //This specific condition deals with house 
                                //numbers below 10 (having the correct number of
                                //spaces).
                                if ((space + 1) < 10)
                                {
                                    Console.Write($"{space + 1}             " +
                                        $"  ");
                                }
                                //This specific condition deals with house 
                                //numbers from and above 10 (having the correct
                                //number of spaces).
                                else
                                {
                                    Console.Write($"{space + 1}             " +
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

                            //This row is simply empty, having only the
                            //division between diferent houses.
                            case 2:
                                Console.Write("|                ");
                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            case 3:
                                Console.Write("|                ");
                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            //This row is simply empty, having only the
                            //division between diferent houses.
                            case 4:
                                Console.Write("|                ");
                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            case 5:
                                Console.Write("|                ");
                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                            //This row is simply empty, having only the
                            //division between diferent houses.
                            case 6:
                                Console.Write("|                ");
                                if (space == 4 || space == 9 || space == 14 ||
                                    space == 19 || space == 24)
                                {
                                    Console.Write("|");
                                }
                                break;

                                //This row defines the bottom limit of the map
                                //grid.
                            case 7:
                                Console.Write("+----------------");
                                if (space == 4 || space == 9 || space == 14 || 
                                    space == 19 || space == 24)
                                {
                                    Console.Write("+");
                                }
                                break;
                        }
                    }
                    Console.Write("\n");
                }

            }
            Console.Write("+----------------+----------------+----------------+" +
            "----------------+----------------+\n\n");
        }
    }
    
    }
}
