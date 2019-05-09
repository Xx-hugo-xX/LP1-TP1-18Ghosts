using System;

namespace _18Ghosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            CheckforWin winningCondition = new CheckforWin();

            Render render = new Render();

            Player p1 = new Player();
            Player p2 = new Player();

            render.DrawMap();
 

            Console.WriteLine($"{p1.R1.ghostState}");


                
        }
    }
}
