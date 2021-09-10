using System;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snakes And Ladder Game!!!");
            Console.WriteLine("Please, press enter key to roll the die, values between 1 and 6");
            Console.WriteLine("Start in 1 square and game finishes when player wins and this is when reachs 100 square,");
            Console.WriteLine("if rolls a die and the next square is over 100 then your token does not move from last square");
            Console.WriteLine("Press enter to start.");
            Console.ReadLine();

            SnakesAndLaddersEngine snakesAndLaddersEngine = new SnakesAndLaddersEngine();
            while(!snakesAndLaddersEngine.PlayerWin())
            {
                Console.WriteLine();
                Console.WriteLine($"You are in {snakesAndLaddersEngine.GetCurrentPosition()} position");
                Console.WriteLine("Press enter to throw the dice...");
                Console.ReadLine();
                Console.WriteLine($"--> You got {snakesAndLaddersEngine.RollDie()} <--");

            }
            Console.WriteLine("You win!!!");
        }
    }
}
