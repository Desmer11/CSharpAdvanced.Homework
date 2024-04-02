using System.Data.SqlTypes;
using static System.Formats.Asn1.AsnWriter;

namespace PaperRockScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputC;
            int randomInt;
            int scorePlayer = 0;
            int scoreC = 0;
            bool playAgain = true;
            while (playAgain)
            {
                while (scorePlayer < 5 && scoreC < 5)
                {
                    Console.WriteLine("Choose Paper - Rock - Scissor");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToLower();

                    Random random = new Random();
                    randomInt = random.Next(1,4);

                    switch (randomInt)
                    {
                        case 1:
                            inputC = "paper";
                            Console.WriteLine("Computer Choose PAPER");
                            if (inputPlayer == "paper")
                            {
                                Console.WriteLine("\nDRAW");
                           }
                            else if(inputPlayer == "rock")
                            {
                                Console.WriteLine("\nLOSS");
                              scoreC++;
                            }
                            else if (inputPlayer == "scissor")
                            {
                               Console.WriteLine("\nWIN");
                                scorePlayer++;
                            }
                         break;
                        case 2:
                            inputC = "rock";
                            Console.WriteLine("Computer Choose ROCK");
                           if (inputPlayer == "rock")
                            {
                                Console.WriteLine("\nDRAW");
                            }
                           else if (inputPlayer == "scissor")
                            {
                                Console.WriteLine("\nLOSS");
                                scoreC++;
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("\nWIN");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputC = "scissor";
                            Console.WriteLine("Computer Choose SCISSOR");
                            if (inputPlayer == "scissor")
                            {
                                Console.WriteLine("\nDRAW");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("\nLOSS");
                                scoreC++;
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("\nWIN");
                                scorePlayer++;
                            }
                            break;
                        default: 
                            Console.WriteLine("INVALID");
                            break;
                        }
                    Console.WriteLine($"Score Player: {scorePlayer}\n" +
                    $"Score Computer: {scoreC}");
                    }
                if (scorePlayer == 5)
                {
                    Console.WriteLine("\n\n                     YOU WIN!!!");
                }
                else if (scoreC == 5)
                {
                    Console.WriteLine("\n\n                     YOU LOSE!!!");
                }
                Console.WriteLine("Play Again??? y/n");
                string loop = Console.ReadLine().ToLower();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
















