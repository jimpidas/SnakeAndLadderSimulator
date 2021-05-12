using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        public class SnakeAndLadder
        {
            public const int IsLadder = 1;
            public const int IsSnake = 2;


            static void Main(string[] args)
            {
                int PositionOfPlayer = 0;
                int dieRollCount = 0;
                while (PositionOfPlayer < 100)
                {
                    dieRollCount++;
                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case IsLadder:
                            Console.WriteLine("Yeah! its a ladder,please step up");
                            PositionOfPlayer += dice;
                            break;

                        case IsSnake:
                            Console.WriteLine("Opss! its a snake,you are going down");
                            PositionOfPlayer -= dice;
                            if (PositionOfPlayer < 0)
                                PositionOfPlayer = 0;
                            break;

                        default:
                            Console.WriteLine("You cannot move");
                            break;
                    }
                    if (PositionOfPlayer > 100)
                    {
                        PositionOfPlayer -= dice;
                        Console.WriteLine("Cannot move ...please roll again");
                    }
                    Console.WriteLine("The player rolled a die " + dice + ",and now at  position : " + PositionOfPlayer);
                }
                Console.WriteLine("The total no of time die was rolled to win is :" + dieRollCount);
            }
        }
    }
}






