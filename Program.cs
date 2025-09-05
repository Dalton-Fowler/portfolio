//Dalton Fowler
//CISS 201 Agile Software Development
//March 26th, 2024
class Program
{
    static string UserShape()
    {
        string str;
        str = "ROCK";
        bool isCorrectSpelling = false;
        while (!isCorrectSpelling)
        {
            Console.WriteLine("Enter Rock, Paper, or Scissors:");
            str = Console.ReadLine().ToUpper();
            if (str == "ROCK" || str == "PAPER" || str == "SCISSORS")
                isCorrectSpelling = true;
        }
        return str;
    }
    static string ComputerShape()
    {
        string str;
        str = "PAPER";
        Random random = new Random();
        int randomNumber = random.Next(1, 4);
        switch (randomNumber) 
        {
            case 1:
                str = "ROCK";
                break;
            case 2:
                str = "PAPER";
                break;
            case 3:
                str = "SCISSORS";
                break;
        }
        return str;
    }
    static string Winner(string user, string computer)
    {
        string winner = "Nobody";
        if (user == "ROCK" && computer == "PAPER"
            || user == "PAPER" && computer == "SCISSORS"
            || user == "SCISSORS" && computer == "ROCK")
            winner = "computer";
        else if (user == "ROCK" && computer == "SCISSORS"
            || user == "PAPER" && computer == "ROCK"
            || user == "SCISSORS" && computer == "PAPER")
            winner = "Players";
        return winner;  
    }
    static void Main()
    {
        bool playAgain = true;
        while (playAgain)
        {
            string userShape = UserShape();
            string computerShape = ComputerShape();
            string winner = Winner(userShape, computerShape);
            Console.WriteLine($"User shape: {userShape}");
            Console.WriteLine($"Computer shape: {computerShape}");
            Console.WriteLine($"The winner is: {winner}");
            Console.WriteLine("Play again? y/n");
            string choice = Console.ReadLine().ToUpper();
            if (choice == "Y" || choice == "YES")
                playAgain = true;
            else
            {
                Console.WriteLine("Thanks for playing.");
                playAgain = false;
            }
        }
    }
}

