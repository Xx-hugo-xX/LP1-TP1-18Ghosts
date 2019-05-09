using System;

namespace _18Ghosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            Player p1 = new Player();
            Player p2 = new Player();
            p1.UpdateLists();

            Render render = new Render();

            CheckforWin checkforWin = new CheckforWin();

            Movement movement = new Movement();

            GhostRespawn ghostRespawn = new GhostRespawn();

            GameLoop gameLoop = new GameLoop();

            gameLoop.RunGameLoop(board, render, p1, p2, movement, ghostRespawn, checkforWin);

            for (int i = 0; i < 9; i++)
            {
                if (p1.ghostList[i].name != null)
                {
                    Console.WriteLine($"{p1.ghostList[i].name}");
                }
            }
            
        }
    }
}
