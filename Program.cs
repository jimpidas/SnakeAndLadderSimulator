using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        public class SnakeAndLadder
        {
            public const int ISLadder = 1;
            public const int ISSnake = 2;
            public const int ISPlayer1 = 0;
            public const int ISPlayer2 = 0;


            static void Main(string[] args)
            {
                int player = 0;
                int PositionOfPlayer1 = 0;
                int PositionOfPlayer2 = 0;
                int dieRollCount = 0;
                while (PositionOfPlayer1 < 100 && PositionOfPlayer2 < 100)
                {
                    dieRollCount++;
                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case ISLadder:
                            Console.WriteLine("Yeah! its a ladder,please step up");
                            if (player == ISPlayer1)
                                PositionOfPlayer1 += dice;
                            else
                                PositionOfPlayer1 += dice;
                            break;

                        case ISSnake:
                            Console.WriteLine("Opss! its a snake,you are going down");

                            if (player == ISPlayer2)
                            {
                                PositionOfPlayer2 -= dice;
                                if (PositionOfPlayer2 < 0)
                                    PositionOfPlayer2 = 0;
                            }
                            else
                            {
                                PositionOfPlayer1 -= dice;
                                if (PositionOfPlayer1 < 0)
                                    PositionOfPlayer1 = 0;
                            }
                            break;

                        default:
                            Console.WriteLine("You cannot move");
                            break;
                    }
                    if (PositionOfPlayer1 > 100 || PositionOfPlayer2 > 100)
                    {

                        Console.WriteLine("Cannot move ...please roll again");
                        if (player == ISPlayer1)
                            PositionOfPlayer1 -= dice;
                        else
                            PositionOfPlayer2 -= dice;


                    }
                    Console.WriteLine("The player 1 rolled a die " + dice + ",and now at position : \t" + PositionOfPlayer1 + "and the option is: " + option);
                    Console.WriteLine("The player 2 rolled a die " + dice + ",and now at position : \t" + PositionOfPlayer2 + "and the option is: " + option);


                    if (option == ISLadder)
                    {
                        Console.WriteLine("Congrats! its an ladder, you got one more Chance to roll the die");
                    }
                    else if (player == ISPlayer1)
                    {
                        Console.WriteLine("Second Player turn");
                        player = 1;
                    }
                    else
                    {
                        Console.WriteLine("First Player Turn");
                        player = 0;
                    }
                }
                Console.WriteLine("The total no of time die was rolled to win is :" + dieRollCount);
                if (PositionOfPlayer1 == 100)
                {
                    Console.WriteLine("Player1 Wins");
                }
                else
                {
                    Console.WriteLine("Player2 Wins");
                }
            }
        }
    }
}







