using System;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
			int count = 0;

            // run get app info function
			getAppInfo();

            // ask and retrieve user details
			userDetails();

			while (true)
			{
				// init correct number
				//int correctNumber = 7;

				//create new random object
				Random random = new Random();

				int correctNumber = random.Next(1, 10);

				// init guess var
				int guess = 0;

				// ask user for number
				Console.WriteLine("Guess a number between 1 and 10");

				// while guess is not correct
				while (guess != correctNumber)
				{
					// get user input
					string inputValue = Console.ReadLine();

					// make sure user inputs a number
					if (!int.TryParse(inputValue, out guess))
					{

						// print error message
						printColorMessage(ConsoleColor.Red, "User numbers only");

						// keep going
						continue;
					}

					// parse string into guess int
					guess = Int32.Parse(inputValue);

					// match guess to correct number
					if (guess != correctNumber)
					{

						printColorMessage(ConsoleColor.Red, "Wrong number, Please try again");
					}else if(guess == correctNumber)
					{
						// output success message
						printColorMessage(ConsoleColor.Green, "Congratulations, you guessed the number!");
						count++;
						Console.WriteLine("You have guessed correctly " + count + " times!");
					}
				}


				// ask to play again
				Console.WriteLine($"Play again? [Y or N]");

				// get answer
				string answer = Console.ReadLine().ToUpper();

                if(answer == "Y") {
					continue;
				}
                else if (answer == "N")
				{
						// output success message
						printColorMessage(ConsoleColor.Green, "Thanks for playing!");
						Console.WriteLine("Your score: " + count);
						return;
				}
				else
				{
					return;
				}

			}
		}

        // get and display app info
        static void getAppInfo()
		{
			// set app vars
			string appName = "Number guesser";
			string appVersion = "1.0.3";
			string appAuthor = "Caio Alves";


			// change text colour
			Console.ForegroundColor = ConsoleColor.Black;

			// write out app info
			Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

			// reset text colour
			Console.ResetColor();

		}

        // ask user name and greet
        static void userDetails()
		{
			// ask users name
			Console.WriteLine("What is your name?");

			// Get user input
			string input = Console.ReadLine();

				Console.WriteLine("Hello {0}, let's play a game...", input.ToUpper());
		}

        // print color message
        static void printColorMessage(ConsoleColor color, string message)
		{
			Console.ForegroundColor = color;

			Console.WriteLine(message);

			Console.ResetColor();
		}
    }
}
