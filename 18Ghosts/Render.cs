using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Render
    {
        //Método que demonstra quais os fantasmas que cada jogador tem,        
        //exemplo:

        /*Fantasmas ativos:
            *  Player1: R(nº) / Y(nº) / B(nº)
            *  Player2: R(nº) / Y(nº) / B(nº)
            */

        // Method that shows the number of active ghosts for both Players
        private void ActvGhosts(Player p1, Player p2) {

            Console.WriteLine("Active Ghosts:");
            //Shows the number of Player1's active ghosts (ghosts in the board)
            Console.WriteLine("Player1: R({})" + " / " + "Y({})" + " / " 
                + "B({})");
            //Shows the number of Player2's active ghosts (ghosts in the board)
            Console.WriteLine("Player2: R({})" + " / " + "Y({})" + " / "
                + "B({})");

        }

        //Método que mostra quais os fantasmas - de cada jogador - que se
        //encontram nas catacumbas, exemplo:

        /*Catacumbas:
            *  Player1: R(nº) / G(nº) / B(nº)
            *  Player2: R(nº) / G(nº) / B(nº)
            */

        //Método que demonstra de quem é o turno, exemplo:

        /*Turno: P1
        */

        //Método que apresenta a prioridade dos fantasmas em combate,
        //exemplo:

        /*R -> G -> B -> R
        * 
        * ou:
        *
        *    R
        *  /   \
        * B --- G
        * 
        */

        //UNICODE
        //poderao dar jeito os seguintes símbolos:
        // U+142F
        // U+1431
        // U+1433
        // U+1438

    }
}
