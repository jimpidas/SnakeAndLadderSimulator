
using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        public const int player = 0;
        static void Main(string[] args)
        {
            int PositionOfPlayer = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);


            Console.WriteLine("The player is at position " + PositionOfPlayer + ",and rolled a die : " + dice);

        }
    }
}


