// See https://aka.ms/new-console-template for more information







var helloWorld = () => 222;

var text = string? () => null;
/*
Console.WriteLine(helloWorld());

Console.WriteLine("what day is today: ");
var days = Console.ReadLine();

var result = days switch
{
    "Saturday" => "Yay manta wa sabti",
    "Sunday" => "Yay manta wa axad",
    "Monday" => "Yay manta wa isniin",
    "Tuesday" => "Yay manta wa salaasa",
    "Wednesday" => "Yay manta wa arbaca",
    "Thrusday" => "Yay manta wa khamiis",
    "Friday" => "Yay manta wa jimce",
    _ => "Ma jidho maalintaasi"
};

Console.WriteLine(result);

Console.WriteLine("what is the temp: ");
var temp = Convert.ToDouble(Console.ReadLine());


if (temp >= 10 && temp <= 25)
{

    Console.WriteLine("Baby you can go outside and have fun 😍");
}
else if (temp >= 26)
{
    Console.WriteLine("Baby it's kinda hot my friendo  😶");
}
else if (temp <= 9)
{
    Console.WriteLine("it's cold outside sit down  💢");
}
*/


//Guessing game --------------------------------------------------------------------------------------------------

/*
Random rnd = new Random();
int guessNum;
int inputGuess;
int max = 100;
int min = 1;
bool playAgain = true;
int guesses;
string? response;

while (playAgain)
{
    guessNum = rnd.Next(min, max + 1);
    inputGuess = 0;
    guesses = 0;
    response = "";


    while (guessNum != inputGuess)
    {

        Console.Write($"Guess a number between {min} - {max}: ");
        inputGuess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Guess: {inputGuess}");

        if (inputGuess > guessNum)
        {
            Console.WriteLine($"{inputGuess} is too high!");
        }
        else if (inputGuess < guessNum)
        {
            Console.WriteLine($"{inputGuess} is too low!");
        }
        guesses++; 
    }

    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("You Win :)");
    Console.WriteLine($"{guessNum} Guessing Number");

    Console.WriteLine($"{guesses} Guesses");

    Console.ResetColor();




    Console.WriteLine("Would you like to play again (Y/N) :) : ");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;

        Console.WriteLine("Thanks for playing ...");
    }

}

*/

//End of guessing game   --------------------------------------------------------------------------------------------------




//Rock paper scisssor Game -----------------------------------------------------------------------------------------------

/*
Random random = new Random();
bool plyAgain = true;
string player;
string computer;
string answer;

while (plyAgain)
{

    player = "";
    computer = "";
    answer = "";


    while (player != "1" && player != "2" && player != "3")
    {
        Console.Write("Enter 1-ROCK, 2-PAPER or 3-SCISSORS (choose numbers): ");

        player = Console.ReadLine();


    }

    computer = random.Next(1, 4) switch
    {
        1 => "ROCK",
        2 => "PAPER",
        3 => "SCISSORS",
        _ => "none"

    };
    Console.ForegroundColor = ConsoleColor.White;
    if (player == "1")
    {

        Console.WriteLine($"Player: ROCK");
    }
    else if (player == "2")
    {
        Console.WriteLine($"Player: PAPER");
    }
    else
    {
        Console.WriteLine($"Player: SCISSORS");
    }

    Console.WriteLine($"Computer: {computer}");

    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    switch (player)
    {
        case "1":
            if (computer == "ROCK")
            {
                Console.WriteLine("it's a draw");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You won!");
            }
            break;
        case "2":
            if (computer == "ROCK")
            {
                Console.WriteLine("You won!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("it's a draw");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            break;
        case "3":
            if (computer == "ROCK")
            {
                Console.WriteLine("You lose!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("it's draw");
            }
            break;
    }
    Console.ResetColor();

    Console.WriteLine("Would you like to play again (Y/N) :)  ");
    answer = Console.ReadLine().ToUpper();


    if (answer == "Y")
    {
        plyAgain = true;
    }
    else
    {
        plyAgain = false;

        Console.WriteLine("Thanks for playing ...");
    }


}
*/

// Rock paper scisssor Game ----------------------------------------------------------------







