namespace MaoriAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*The game displays a menu of difficulty levels to choose from, and the player selects one. After selecting a difficulty level, the game clears the console and displays instructions for the quiz.

              The quiz consists of 5 multiple-choice questions, with each correct answer adding one point to the player's score. The game displays the player's score and the number of questions remaining after each question. The game loops through each question using a for loop with an iteration of 1.

             Each question is an element in an array of strings, with the answer choices presented to the player using a switch statement. The code also includes validation for invalid input, requiring the player to select a valid answer. */



            Console.WriteLine("Welcome to the Maori Quiz! In this quiz you will get to choose between three difficulties easy, medium, and hard.");
            Console.WriteLine("\nThis is a multiple choice quiz of 5 questions each difficulty. You will get to choose between the choices (A-D). For every right answer your score will be added by 1 point and will be displayed.");
            Console.WriteLine("\n\t\t\t\t\t------PRESS ANY KEY TO CONTINUE------");


        }
    }
}