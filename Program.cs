namespace MaoriAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {//start of main method
            
            /*The game displays a menu of difficulty levels to choose from, and the player selects one. After selecting a difficulty level, the game clears the console and displays instructions for the quiz.

              The quiz consists of 5 multiple-choice questions, with each correct answer adding one point to the player's score. The game displays the player's score and the number of questions remaining after each question. The game loops through each question using a for loop with an iteration of 1.

             Each question is an element in an array of strings, with the answer choices presented to the player using a switch statement. The code also includes validation for invalid input, requiring the player to select a valid answer. */



            Console.WriteLine("Welcome to the Maori Quiz! In this quiz you will get to choose between three difficulties easy, medium, and hard.");
            Console.WriteLine("\nThis is a multiple choice quiz of 5 questions each difficulty. You will get to choose between the choices (A-D). For every right answer your score will be added by 1 point and will be displayed.");
            Console.WriteLine("\n\t\t\t\t\t------PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
            Console.Clear();
            start();
        }//end of main method

        static void start()
        {//start of start method

            
            Console.WriteLine("Welcome to the Maori Quiz!"); //greets the user
            Console.Write("Please input your name: "); //asks the user to input their name
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello {name}! Welcome to the Maori Quiz!"); //displays the name
            Console.WriteLine("\n\t\t\t------PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
            menu(name);

        }//end of start method

        static void menu(string name)
        {//start of menu method
            
            string difficulty = ""; //used string instead of int so when the user enters a number or nothing it will still display the error message
            
            Console.WriteLine($"Please choose a difficulty {name}:");
            Console.WriteLine("1. Easy\n2. Medium\n3. Hard");
            Console.Write("Please enter a number 1-3: ");
            difficulty = Console.ReadLine();

            //while loop validating the choices, if the user doesnt enter between (1-3) it will display the error message
            
            while (difficulty != "1" && difficulty != "2" && difficulty != "3")
            {
                Console.Write($"\nInvalid input, {difficulty} is  not a valid choice. Please enter a number between 1-3: ");
                difficulty = (Console.ReadLine());
            }


            //The switch statement is selecting a function to execute based on the value of the "difficulty" variable.
             switch (difficulty)
            {
                case "1":
                    Easy(name);
                    break;
                case "2":
                    Medium(name);
                    break;
                case "3":
                    Hard(name);
                    break;
            }

        }//end of menu method

        static void Easy(string name)
        {//start of easy method



        }//end of easy method

        static void Medium(string name)
        {//start of medium method

        }//end of medium method

        static void Hard(string name)
        {//start of hard method

        }//end of hard method
    }
}