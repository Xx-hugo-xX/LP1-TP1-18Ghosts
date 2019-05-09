using System;

namespace _18Ghosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            CheckforWin checkforWin = new CheckforWin();

            GhostRespawn ghostRespawn = new GhostRespawn();

            Movement movement = new Movement();

            Render render = new Render();

            Player p1 = new Player();
            Player p2 = new Player();

            GameLoop gameLoop = new GameLoop();

            gameLoop.RunGameLoop(board, render, p1, p2, movement, ghostRespawn, checkforWin);
        }
    }
}
