using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Player
    {
        //Instance Varibles
        public Ghost[] ghostList { get; set; }
        public Ghost[] insideGhosts { get; set; }
        public Ghost[] runawayGhosts { get; set; }
        public Ghost[] lockedGhosts { get; set; }
        public Ghost R1 { get; set; }
        public Ghost R2 { get; set; }
        public Ghost R3 { get; set; }
        public Ghost B1 { get; set; }
        public Ghost B2 { get; set; }
        public Ghost B3 { get; set; }
        public Ghost Y1 { get; set; }
        public Ghost Y2 { get; set; }
        public Ghost Y3 { get; set; }

        // Constructor class
        public Player()
        {
            //Create and initialize an array of ghosts for each player


            //Define every ghost a player has from the beginning
            R1 = new Ghost("r1", ConsoleColor.Red, new Position(0, 0));
            R2 = new Ghost("r2", ConsoleColor.Red, new Position(0, 0));
            R3 = new Ghost("r3", ConsoleColor.Red, new Position(0, 0));
            B1 = new Ghost("b1", ConsoleColor.Blue, new Position(0, 0));
            B2 = new Ghost("b2", ConsoleColor.Blue, new Position(0, 0));
            B3 = new Ghost("b3", ConsoleColor.Blue, new Position(0, 0));
            Y1 = new Ghost("y1", ConsoleColor.Yellow, new Position(0, 0));
            Y2 = new Ghost("y2", ConsoleColor.Yellow, new Position(0, 0));
            Y3 = new Ghost("y3", ConsoleColor.Yellow, new Position(0, 0));

            ghostList = GetGhostList();
            insideGhosts = InsideGhostUpdate();
            runawayGhosts = RunawayGhostUpdate();
            lockedGhosts = LockedGhostUpdate();
        }


        public Ghost[] GetGhostList()
        {
            Ghost[] ghostList = new Ghost[9];

            ghostList[0] = R1;
            ghostList[1] = R2;
            ghostList[2] = R3;
            ghostList[3] = B1;
            ghostList[4] = B2;
            ghostList[5] = B3;
            ghostList[6] = Y1;
            ghostList[7] = Y2;
            ghostList[8] = Y3;

            return ghostList;
        }


        public Ghost[] InsideGhostUpdate()
        {
            int insideCounter = 0;
            int insideAdding = 0;

            // Checks how many ghosts are on each list
            for (int i = 0; i < 9; i++)
            {
                if (ghostList[i].ghostState == GhostState.Inside)
                    insideCounter++;
            }

            // Creates a new list of ghosts with the right size for each list
            Ghost[] insideGhosts = new Ghost[insideCounter];

            //Adiciona cada fantasma à lista devida
            for (int i = 0; i < 9; i++)
            {
                if (ghostList[i].ghostState == GhostState.Inside)
                {
                    insideGhosts[insideAdding] = ghostList[i];
                    insideAdding++;
                }
            }
            return insideGhosts;
        }


        public Ghost[] RunawayGhostUpdate()
        {
            int runawayCounter = 0;
            int runawayAdding = 0;

            // Checks how many ghosts are on each list
            for (int i = 0; i < 9; i++)
            {
                if (ghostList[i].ghostState == GhostState.Runaway)
                    runawayCounter++;
            }
            // Creates a new list of ghosts with the right size for each list
            Ghost[] runawayGhosts = new Ghost[runawayCounter];

            //Adiciona cada fantasma à lista devida
            for (int i = 0; i < 9; i++)
            {
                if (ghostList[i].ghostState == GhostState.Runaway)
                {
                    runawayGhosts[runawayAdding] = ghostList[i];
                    runawayAdding++;
                }
            }
            return runawayGhosts;
        }


        public Ghost[] LockedGhostUpdate()
        {
            int lockedCounter = 0;
            int lockedAdding = 0;

            // Checks how many ghosts are on the list
            for (int i = 0; i < 9; i++)
            {
                if (ghostList[i].ghostState == GhostState.Locked)
                    lockedCounter++;
            }

            // Creates a new list of ghosts with the right size
            Ghost[] lockedGhosts = new Ghost[lockedCounter];

            //Adiciona cada fantasma à lista devida
            for (int i = 0; i < 9; i++)
            {
                if (ghostList[i].ghostState == GhostState.Locked)
                {
                    lockedGhosts[lockedAdding] = ghostList[i];
                    lockedAdding++;
                }
            }
            return lockedGhosts;
        }


        public Position GetPosition(Board board)
        {
            Console.WriteLine("Select a space to move (numbers on the top" +
                " right corner)");
            int position = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = PositionForNumber(position);
            return desiredCoordinate;
        }

        public Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0);
                case 2: return new Position(0, 1);
                case 3: return new Position(0, 2);
                case 4: return new Position(0, 3);
                case 5: return new Position(0, 4);
                case 6: return new Position(1, 0);
                case 7: return new Position(1, 1);
                case 8: return new Position(1, 2);
                case 9: return new Position(1, 3);
                case 10: return new Position(1, 4);
                case 11: return new Position(2, 0);
                case 12: return new Position(2, 1);
                case 13: return new Position(2, 2);
                case 14: return new Position(2, 3);
                case 15: return new Position(2, 4);
                case 16: return new Position(3, 0);
                case 17: return new Position(3, 1);
                case 18: return new Position(3, 2);
                case 19: return new Position(3, 3);
                case 20: return new Position(3, 4);
                case 21: return new Position(4, 0);
                case 22: return new Position(4, 1);
                case 23: return new Position(4, 2);
                case 24: return new Position(4, 3);
                case 25: return new Position(4, 4);
                default: return null;
            }
        }
    }
}
