namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PigDice Game!");
            Console.WriteLine("You have 3 turns to win the game");
            Console.WriteLine("If your Total Score exceeds 20 within 3 turns, you win the game!");
            Console.WriteLine("Press (r) to roll a die and Press (h) to hold a die.");
            Console.WriteLine("Remember if you do not hold a die, you will lose all the points gained in that turn.");
            Console.WriteLine("If the Die shows 1, your turn is over and you will lose all points gained in that turn.");
            
            PigDice pigDice = new PigDice();
            PigDice.RollADie();
        }
    }
}
