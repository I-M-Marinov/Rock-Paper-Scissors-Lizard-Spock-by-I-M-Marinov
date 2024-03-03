using System.Text;

            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";
            const string lizard = "Lizard";
            const string spock = "Spock";

            int wonGames = 0;
            int lostGames = 0;
            int drawnGames = 0;


            while (true)
            {

                Console.Write("Choose [R]ock, [P]aper, [S]cissors, [L]izard or [SP]ock : ");
                string playerMove = Console.ReadLine().ToLower().TrimEnd();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = scissors;
                }
                else if (playerMove == "l" || playerMove == "lizard")
                {
                    playerMove = lizard;
                }
                else if (playerMove == "sp" || playerMove == "spock")
                {
                    playerMove = spock;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again...");
                    continue;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 6);
                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = rock;
                        break;
                    case 2:
                        computerMove = paper;
                        break;
                    case 3:
                        computerMove = scissors;
                        break;
                    case 4:
                        computerMove = lizard;
                        break;
                    case 5:
                        computerMove = spock;
                        break;
                }

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"The computer chose --{computerMove.ToUpper()}--");
                Console.WriteLine($"You chose --{playerMove.ToUpper()}--");
                Console.WriteLine("---------------------------------------------------");

                if ((playerMove == rock && computerMove == scissors) ||
                    (playerMove == rock && computerMove == lizard) ||
                    (playerMove == paper && computerMove == rock) ||
                    (playerMove == paper && computerMove == spock) ||
                    (playerMove == scissors && computerMove == paper) ||
                    (playerMove == scissors && computerMove == lizard) ||
                    (playerMove == lizard && computerMove == spock) ||
                    (playerMove == lizard && computerMove == paper) ||
                    (playerMove == spock && computerMove == scissors) ||
                    (playerMove == spock && computerMove == rock))
                {
                    wonGames++;
                    Console.WriteLine("You won.");
                    Console.WriteLine("---------------------------------------------------");
                }
                else if ((computerMove == rock && playerMove == scissors) ||
                         (computerMove == rock && playerMove == lizard) ||
                         (computerMove == paper && playerMove == rock) ||
                         (computerMove == paper && playerMove == spock) ||
                         (computerMove == scissors && playerMove == paper) ||
                         (computerMove == scissors && playerMove == lizard) ||
                         (computerMove == lizard && playerMove == spock) ||
                         (computerMove == lizard && playerMove == paper) ||
                         (computerMove == spock && playerMove == scissors) ||
                         (computerMove == spock && playerMove == rock))
                {
                    lostGames++;
                    Console.WriteLine("You lost.");
                    Console.WriteLine("---------------------------------------------------");
                }
                else
                {
                    drawnGames++;
                    Console.WriteLine("This game was a draw.");
                    Console.WriteLine("---------------------------------------------------");
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string playAgain = Console.ReadLine().ToLower();

                while (true)
                {
                    if (playAgain != "y")
                    {
                        if (playAgain != "n")
                        {
                            Console.WriteLine("Invalid Input. Try Again...");
                            playAgain = Console.ReadLine().ToLower();
                            continue;
                        }

                    }
                    break;
                }

                if (playAgain == "n")
                {
                    Console.Clear();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("---------------------------------------------------");
                    sb.AppendLine("Here are the stats for this session:");
                    sb.AppendLine();
                    sb.AppendLine($"Games WON -----> {wonGames}");
                    sb.AppendLine($"Games LOST -----> {lostGames}");
                    sb.AppendLine($"Games DRAWN -----> {drawnGames}");
                    sb.AppendLine("---------------------------------------------------");

                    Console.WriteLine(sb);
                    Console.WriteLine("Thanks for playing! See you next time..");

                    Environment.Exit(1);
                }

                Console.Clear();
            }


