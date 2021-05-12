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
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case IsLadder:
                        PositionOfPlayer += dice;
                        break;

                    case IsSnake:
                        PositionOfPlayer -= dice;
                        if (PositionOfPlayer < 0)
                            PositionOfPlayer = 0;
                        break;

                    default: break;
                }
                Console.WriteLine("The player rolled a die  " + dice + ",and now at position : " + PositionOfPlayer);
            }

        }
    }
}
