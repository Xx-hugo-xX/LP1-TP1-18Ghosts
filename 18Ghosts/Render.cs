using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Render
    {

        // Method that shows the number of active Ghosts for both Players
        //(Ghosts in the board)
        private void ActvGhosts(Player p1, Player p2)
        {

            Console.WriteLine("Active Ghosts:");
            //Shows the number of Player1's active Ghosts
            Console.WriteLine($"Player1: R({}) / Y({}) / B({})");
            //Shows the number of Player2's active Ghosts
            Console.WriteLine($"Player2: R({}) / Y({}) / B({})");

        }

        // Method that shows the number of both Players captured Ghosts (Ghosts
        //in the catacombs)
        private void CapturedGhosts(Player p1, Player p2)
        {

            Console.WriteLine("Active Ghosts:");
            //Shows the number of Player1's captured Ghosts
            Console.WriteLine($"Player1: R({}) / Y({}) / B({})");
            //Shows the number of Player2's captured Ghosts
            Console.WriteLine($"Player2: R({}) / Y({}) / B({})");

        }

        // Method that shows who's Players turn it is to play
        private void PlayerTurn()
        {
            //Shows wich Player's turn it is to play
            Console.WriteLine($"Turn: {}");
        }

        // Method that shows the players which Ghost (color) is superior to
        //which in combat
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

        // Method that draws the map and Player's Ghosts
        private void DisplayMap()
        {

        }
    
    }
}
