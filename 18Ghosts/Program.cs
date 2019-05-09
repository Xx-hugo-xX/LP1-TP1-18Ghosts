using System;
using System.Text;

namespace _18Ghosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Board board = new Board();

            Player p1 = new Player();
            Player p2 = new Player();


            Portals redPortal = new Portals('\u2191', ConsoleColor.Red,
                new Position(0, 2), PortalState.North);
            Portals bluePortal = new Portals('\u2193', ConsoleColor.Blue,
                new Position(4, 2), PortalState.South);
            Portals yellowPortal = new Portals('\u2192', ConsoleColor.Yellow,
                new Position(2, 4), PortalState.East);

            Render render = new Render();

            CheckforWin checkforWin = new CheckforWin();

            Movement movement = new Movement();

            GhostRespawn ghostRespawn = new GhostRespawn();

            GameLoop gameLoop = new GameLoop();

            Setup setup = new Setup();

            setup.SetPlayerSpaces(render, board, p1, p2, redPortal, bluePortal,
                yellowPortal, p1.insideGhosts, p1.runawayGhosts,
                p1.lockedGhosts, p1.ghostList);


            gameLoop.RunGameLoop(board, render, p1, p2, movement, ghostRespawn,
                checkforWin, redPortal, bluePortal, yellowPortal, p1.ghostList);


            
        }
    }
}
