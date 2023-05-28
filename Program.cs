using System;
using System.Diagnostics;
using System.Threading.Tasks.Sources;

namespace MaoriAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {//start of main method

            Console.WriteLine("Welcome to the Maori Quiz! In this quiz you will get to choose between three difficulties easy, medium, and hard.");
            Console.WriteLine("\nThis is a multiple choice quiz of 5 questions each difficulty. You will get to choose between the choices (A-D). For every right answer your score will be added by 2 points. To pass this quiz you will need to score 8 points. Goodluck and have fun!");
            Console.WriteLine("\n\t\t\t\t\t------PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Welcome to the Maori Quiz!"); //greets the user
            Console.Write("Please input your name: "); //asks the user to input their name
            string name = Console.ReadLine();

            while (name == "")
            {//start of while statement
                Console.Write("\nInvalid input, please input your name: ");
                name = Console.ReadLine();
            }//end of while statement

            Console.WriteLine($"\nHello {name}! Welcome to the Maori Quiz!"); //displays the name
            Console.WriteLine("\n\t\t\t------PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
            Console.Clear();

            string difficulty = menu(name);

            Console.Clear();// Clears the menu after the user selects a difficulty and displays the instructions
            Console.WriteLine("This is a 5 question multiple choice quiz. Please Choose an answer between A-D.");
            Console.WriteLine("Your score and the ammount of questions you have left will be displayed on the top left side of the test.");
            Console.WriteLine("\n\t\t\t\t\t-----PRESS ANY KEY TO CONTINUE-----");
            Console.ReadKey();//makes the user press a key before continuing the test
            Console.Clear();
   
            play(difficulty, name);

            Console.Write("\nWould you like to play again? (Y/N): ");
            string retry = Console.ReadLine().ToUpper();

            //while loop that validates the user's input for (Y/N)
            while (retry != "Y" && retry != "N")
            {
                Console.Write($"\n{retry} is not a valid choice. Please choose between (Y/N): ");
                retry = Console.ReadLine().ToUpper();
            }

            switch (retry)
            {
                //if the user chooses "Y" it will return to the menu method and repeat the whole quiz
                case "Y":
                    Console.Clear();
                    menu(name);
                    break;
                //if the user chooses "N" a goodbye message will appear and will thank the use for playing  and end the quiz
                default:
                    Console.WriteLine($"\nGoodbye {name}! Thank you for playing!");
                    break;
            }

        }
        //end of main method

        static string menu(string name) 
        {//start of menu method

            string difficulty; //used string instead of int so when the user enters a number or nothing it will still display the error message

            Console.WriteLine($"Please choose a difficulty {name}:");
            Console.WriteLine("1. Easy\n2. Medium\n3. Hard");
            Console.Write("Please enter a number 1-3: ");
            difficulty = Console.ReadLine();

            //while loop validating the choices, if the user doesnt enter between (1-3) it will display the error message

            while (difficulty != "1" && difficulty != "2" && difficulty != "3")
            {
                Console.Write($"\nInvalid input, {difficulty} is  not a valid choice. Please enter a number between 1-3: ");
                difficulty = Console.ReadLine();
            }
            
            return difficulty;

        }//end of menu method


        //play method that stores all of the questions and answers of each difficulty and loops through all of them
        static void play(string difficulty, string name)
        {//start of playgame method
            string[] questions = null;
            string[] answers = null;
            string user_ans;
            int score = 0;
            switch (difficulty)
            {//start of switch loop
                case "1"://Easy difficulty 
                    questions = new string[5]{"\nWhat is the name of the country where the Maori people are indigenous?\nA. New Zealand\r\nB. Australia\r\nC. Fiji\r\nD. Samoa", "\nWhat is the Maori word for \"goodbye\"\nA. Kia ora\r\nB. Haere mai\r\nC. Ka kite ano\r\nD. Aroha mai", "\nWhat is the name of the famous Maori warrior who is known for his facial tattoos?\nA. Tūhoe\r\nB. Te Rauparaha\r\nC. Tāne Mahuta\r\nD. Māui", "\nWhat is the Maori word for \"family\"\nA. Whānau\r\nB. Hapū\r\nC. Marae\r\nD. Iwi", "\nWhat is the name of the Maori ritual in which a newborn baby is introduced to their family and community?\nA. Karakia\r\nB. Hongi\r\nC. Powhiri\r\nD. Haka"};
                     answers = new string[5]{"A", "C", "B", "A", "C"};
                    break;

                case "2"://medium difficulty
                   questions = new string[5]{ "\nWhat is the traditional Maori greeting?\nA. Kia ora\r\nB. Haere mai\r\nC. Whakapapa\r\nD. Tino rangatiratanga", "\nWhat is the name of the Maori cultural dance?\nA. Haka\r\nB. Waiata\r\nC. Karakia\r\nD. Kapa haka", "\nWhich famous Maori leader signed the Treaty of Waitangi on behalf of the Maori people in 1840?\nA. Te Rauparaha\r\nB. Te Wherowhero\r\nC. Te Puea Herangi\r\nD. Hone Heke","\nWhat is the traditional Maori method of cooking food using heated rocks in a pit?\nA. Hapū\r\nB. Hangi\r\nC. Hui\r\nD. Haka", "\nWhat is the name of the Maori goddess of the sea?\nA. Hine-nui-te-pō\r\nB. Tawhiri-mātea\r\nC. Tangaroa\r\nD. Rongo-mai"};
                    answers = new string[5] { "A", "D", "B", "B", "C"};
                    break;
                case "3"://hard difficulty
                    questions = new string[5] { "\nWhat is the name of the sacred Maori mountain located in the central North Island of New Zealand\nA. Taranaki\r\nB. Tongariro\r\nC. Aoraki\r\nD. Ruapehu", "\nWhat is the name of the Maori language commission responsible for promoting and protecting the Maori language in New Zealand?\nA. Te Puni Kokiri\r\nB. Te Taura Whiri i te Reo Maori\r\nC. Te Mangai Paho\r\nD. Te Whakakitenga Maori", "\nWhat is the name of the Maori goddess of the forest?\nA. Hine-nui-te-po\r\nB. Tane Mahuta\r\nC. Papatuanuku\r\nD. Ranginui", "\nWhat is the name of the traditional Maori art form that involves the carving of wood or stone?\r\nA. Whakairo\r\nB. Raranga\r\nC. Ta moko\r\nD. Kapa haka", "\nWhat is the name of the famous Maori leader who led the Taranaki iwi during the New Zealand Wars of the 1860s\r\nA. Te Rauparaha\r\nB. Wiremu Kingi\r\nC. Te Whiti o Rongomai\r\nD. Hone Heke"};
                    answers = new string[5] { "B", "B", "B", "A", "C"};
                    break;
            }//end of swtich loop
            
            for (int i = 0; i < questions.Length; i++)//loops through all the questions by 5
            {//start of for loop
                Console.WriteLine($"Score:{score}");//displays the score
                Console.WriteLine($"Question {i + 1}");// displays the question number
                Console.WriteLine(questions[i]);//displays the question and choices
                Console.Write("Please choose an answer: ");
                user_ans = Console.ReadLine().ToUpper();

                //while loop validating the choices and will display an error message
                while (user_ans != "A" && user_ans != "B" && user_ans != "C" && user_ans != "D")
                {//start of while loop
                    Console.Write($"\n{user_ans} is not a valid choice. Please choose between A-D:");
                    user_ans = Console.ReadLine().ToUpper();
                }//end of while loop

                if (user_ans.Contains(answers[i]))//if loop that contains the array for the answers and will determine if the answer is correct
                {
                    //if the answer is correct it will display this message
                    Console.WriteLine($"\nGood job {name}! That was the correct answer <3");
                    score = score + 2;

                }
                else if (user_ans != answers[i])
                {
                    //if the answer is wrong it will display this message
                    Console.WriteLine($"\nNice try {name}! The correct answer was {answers[i]}");

                }

                Console.WriteLine("\n\t\t\t\t------PRESS ANY KEY TO CONTINUE------");
                Console.ReadKey();
                Console.Clear();
            }//end of for loop

            //if statement determining the passing score for the quiz
            if (score <= 6)
            {//start of if
                Console.WriteLine($"Good effort {name}! You scored {score}/10, so close!");//if the user gets 6 below they fail
            }// end of if 
            else if (score >= 8)
            {//start of else if
                Console.WriteLine($"Amazing job {name}! You scored {score}/10, fantastic! ");//if the user gets anything higher they pass
            }//end of else if

        }//end of playgame method

    }
}