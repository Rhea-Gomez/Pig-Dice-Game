using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class PigDice
    {
        public static int turnScore = 0;
        public static int turn = 1;
        public static int totalScore = 0;
        

        public static void RollADie()
        {
            do
            {
                turnScore = 0;
                Console.WriteLine();
                Console.WriteLine("Turn: " + turn);
                
               
                do
                {
                    Console.WriteLine("Would you like to roll a die or hold a die? (r/h)");
                    string action = Console.ReadLine();
                    Random random = new Random();
                    int die = random.Next(1, 10);
                    if (action == "r")
                    { 
                        Console.WriteLine("Die: " + die);
                        if (die == 1)
                        {
                            turnScore = 0;
                            Console.WriteLine("Turn over");
                            Console.WriteLine("Turn {0} score: {1}", turn, turnScore);
                            Console.WriteLine("Total Score: " + totalScore);
                            turn++;
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            turnScore += die;
      
                        }
                    }
                    else if (action == "h")
                    {
                        totalScore += turnScore;
                        Console.WriteLine("Your Score for Turn {0}: {1}", turn, turnScore);
                        Console.WriteLine("Total Score: " + totalScore);
                        turn++;
                        Console.WriteLine();
                        break;
                    }


                } while (totalScore < 20);
            } while(totalScore < 20);


            
           
                Console.WriteLine($"You finished the game in {turn - 1} turns!");
                Console.WriteLine("Total Score: " + totalScore);
           
        }
    }
}
