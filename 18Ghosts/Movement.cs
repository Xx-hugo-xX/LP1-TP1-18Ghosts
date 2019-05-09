using System;
using System.Collections.Generic;
using System.Text;

namespace _18Ghosts
{
    class Movement
    {
        public Movement()
        {
        }
        public void Move(Board board, Player p1, Player p2)
        {
            Console.WriteLine("Which ghost do you want to move?");
            for (int i = 0; i < p1.insideGhosts.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {p1.insideGhosts[i].name}");
            }

            int option = 0;

            while (option < 1 || option > p1.insideGhosts.Length)
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option < 1 || option > p1.insideGhosts.Length)
                    Console.WriteLine("Please select a valid option.");
            }

            Ghost movingGhostOld = p1.insideGhosts[option - 1];
            Ghost movingGhost = p1.insideGhosts[option - 1];

            Console.WriteLine("Where do you wanna move?");
            Console.WriteLine("1 - NORTH");
            Console.WriteLine("2 - SOUTH");
            Console.WriteLine("3 - WEST");
            Console.WriteLine("4 - EAST");

            option = 0;

            while (option < 1 || option > p1.insideGhosts.Length)
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option < 1 || option > 4)
                    Console.WriteLine("Please select a valid option.");

                if (option == 1)
                {
                    movingGhost.position.Row -= 1;
                }
                else if (option == 2)
                {
                    movingGhost.position.Row += 1;
                }
                else if (option == 3)
                {
                    movingGhost.position.Column -= 1;
                }
                else if (option == 4)
                {
                    movingGhost.position.Column += 1;
                }

                if (MovingConditions(board, p1, p2, movingGhost,
                    movingGhost.position) == false)
                {
                    Console.WriteLine("You can't move to that space.");
                    option = 0;
                }
            }

            if (board.state[movingGhost.position.Row,
                movingGhost.position.Column] == RoomState.Undecided)
            {
                for (int i = 0; i < p1.insideGhosts.Length; i++)
                {
                    if (p1.insideGhosts[i].name == movingGhost.name)
                    {
                        p1.insideGhosts[i].position = movingGhost.position;
                        board.state[movingGhostOld.position.Row,
                            movingGhostOld.position.Column] =
                            RoomState.Undecided;
                    }
                }
            }
            else
            {
                if (board.state[movingGhost.position.Row,
                    movingGhost.position.Column] == RoomState.P1)
                {
                    for (int i = 0; i < p1.insideGhosts.Length; i++)
                    {
                        if (p1.insideGhosts[i].position ==
                        movingGhost.position)
                        {
                            movingGhost.Fight(movingGhost, p1.insideGhosts[i],
                                movingGhost.position);

                        }
                    }
                }
            }
        }

        public bool MovingConditions(Board board, Player p1, Player p2, Ghost ghost, Position movingPosition)
        {
            if (movingPosition.Row < 0 || movingPosition.Row > 4 ||
                movingPosition.Column < 0 || movingPosition.Column > 4)
                return false;

            RoomState positionState = board.state[movingPosition.Row,
                movingPosition.Column];

            if (positionState == RoomState.P1)
            {
                for (int i = 0; i < p1.insideGhosts.Length; i++)
                {
                    if (p1.insideGhosts[i].position.Row == movingPosition.Row
                        && p1.insideGhosts[i].position.Column
                        == movingPosition.Column)
                    {
                        if (p1.insideGhosts[i].color == ghost.color)
                            return false;
                    }
                }
            }
            else if (positionState == RoomState.P2)
            {
                for (int i = 0; i < p2.insideGhosts.Length; i++)
                {
                    if (p2.insideGhosts[i].position.Row == movingPosition.Row
                        && p2.insideGhosts[i].position.Column
                        == movingPosition.Column)
                    {
                        if (p2.insideGhosts[i].color == ghost.color)
                            return false;
                    }
                }
            }
            return true;
        }
    }
}