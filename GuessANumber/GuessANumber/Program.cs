Random randomNumber = new Random();
int computerNumber = randomNumber.Next(1, 101);
bool playAgain = true;
while (playAgain)
{
    Console.Write("Guess a number (1-100): ");
    string playerInput = Console.ReadLine();
    bool isValid = int.TryParse(playerInput, out int playerNumber);
    if (isValid)
    {
        if(playerNumber == computerNumber)
        {
            Console.WriteLine("You guessed it!");
            Console.Write("Do you want to play again? [Y]es/[N]o:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Y":
                case "y":
                case "yes":
                case "Yes":
                    computerNumber = randomNumber.Next(1, 101);
                    playAgain = true;
                    break;
                case "n":
                case "N":
                case "no":
                case "No":
                    playAgain = false;
                    break;
                default:
                    break;
            }
        }
        else if(playerNumber > computerNumber)
        {
            Console.WriteLine("Too High");
        }
        else
        {
            Console.WriteLine("Too Low");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}