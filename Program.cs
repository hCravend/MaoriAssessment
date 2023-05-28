using System;

namespace MaoriAssessment
{
    internal class Program
    {
        static void Main(string[] args, string name)
        {//start of main method
            
            /*The game displays a menu of difficulty levels to choose from, and the player selects one. After selecting a difficulty level, the game clears the console and displays instructions for the quiz.

              The quiz consists of 5 multiple-choice questions, with each correct answer adding one point to the player's score. The game displays the player's score and the number of questions remaining after each question. The game loops through each question using a for loop with an iteration of 1.

             Each question is an element in an array of strings, with the answer choices presented to the player using a switch statement. The code also includes validation for invalid input, requiring the player to select a valid answer. */



            Console.WriteLine("Welcome to the Maori Quiz! In this quiz you will get to choose between three difficulties easy, medium, and hard.");
            Console.WriteLine("\nThis is a multiple choice quiz of 5 questions each difficulty. You will get to choose between the choices (A-D). For every right answer your score will be added by 2 points. To pass this quiz you will need to score 8 points. Goodluck and have fun!");
            Console.WriteLine("\n\t\t\t\t\t------PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
            Console.Clear();

            start();

        static void start()
        {//start of start method
            
            
            Console.WriteLine("Welcome to the Maori Quiz!"); //greets the user
            Console.Write("Please input your name: "); //asks the user to input their name
            string name = Console.ReadLine();

            while (name == "")
            {//start of while statement
                Console.Write("\nNopeee you need to enter your name ._.:");
                name = Console.ReadLine();
            }//end of while statement
            
            Console.WriteLine($"\nHello {name}! Welcome to the Maori Quiz!"); //displays the name
            Console.WriteLine("\n\t\t\t------PRESS ANY KEY TO CONTINUE------");
            Console.ReadKey();
            Console.Clear();
            menu(name);

            

        }//end of start method

        static void menu(string name)
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

            Console.Clear();// Clears the menu after the user selects a difficulty and displays the instructions
            Console.WriteLine("This is a 5 question multiple choice quiz. Please Choose an answer between A-D.");
            Console.WriteLine("Your score and the ammount of questions you have left will be displayed on the top left side of the test.");
            Console.WriteLine("\n\t\t\t\t\t-----PRESS ANY KEY TO CONTINUE-----");
            Console.ReadKey();//makes the user press a key before continuing the test
            Console.Clear();

            //stores all of the easy questions
            string[] EasyQ = new string[5];
            EasyQ[0] = "\nWhat is the name of the country where the Maori people are indigenous?\nA. New Zealand\r\nB. Australia\r\nC. Fiji\r\nD. Samoa";
            EasyQ[1] = "\nWhat is the Maori word for \"goodbye\"\nA. Kia ora\r\nB. Haere mai\r\nC. Ka kite ano\r\nD. Aroha mai";
            EasyQ[2] = "\nWhat is the name of the famous Maori warrior who is known for his facial tattoos?\nA. Tūhoe\r\nB. Te Rauparaha\r\nC. Tāne Mahuta\r\nD. Māui";
            EasyQ[3] = "\nWhat is the Maori word for \"family\"\nA. Whānau\r\nB. Hapū\r\nC. Marae\r\nD. Iwi";
            EasyQ[4] = "\nWhat is the name of the Maori ritual in which a newborn baby is introduced to their family and community?\nA. Karakia\r\nB. Hongi\r\nC. Powhiri\r\nD. Haka";

            //stores all of the easy answers
            string[] EasyA = new string[5];
            EasyA[0] = "A";
            EasyA[1] = "C";
            EasyA[2] = "B";
            EasyA[3] = "A";
            EasyA[4] = "C";
            
            string user_ans;
            int score = 0;
            int Qnum = 1;

            for (int i = 0; i < 5; i++)//loops through all of the questions by 5
            {//start of for loop
                Console.WriteLine($"Score:{score}");//displays the score
                Console.WriteLine($"Question {Qnum}");// displays the question number 
                Console.WriteLine(EasyQ[i]);//displays the question and choices
                Console.Write("Please choose an answer: ");
                user_ans = Console.ReadLine().ToUpper();

                //while loop validating the choices and will display an error message
                while (user_ans != "A" && user_ans != "B" && user_ans != "C" && user_ans != "D")
                {//start of while loop
                    Console.Write($"\n{user_ans} is not a valid choice. Please choose between A-D:");
                    user_ans = Console.ReadLine().ToUpper();
                }//end of while loop

                if (user_ans.Contains(EasyA[i]))//if loops that contains the array for the answers and will determine if the answer is correct
                {
                    //if the answer is correct it will display this message
                    Console.WriteLine($"\nGood job {name}! That was the correct answer <3");
                    score = score + 2;

                }
                else if (user_ans != EasyA[i])
                {
                    //if the answer is wrong it will display this message
                    Console.WriteLine($"\nNice try {name}! The correct answer was {EasyA[i]}");

                }

                Console.WriteLine("\n\t\t\t\t------PRESS ANY KEY TO CONTINUE------");
                Console.ReadKey();
                Qnum++;
                Console.Clear();
            }//end of for loop



            //if statement determining the passing score for the quiz
            if (score <= 6)
            {
                Console.WriteLine($"Good effort {name}! You scored {score}/10, so close!");//if the user gets 6 below they fail
            }
            else if (score >= 8)
            {
                Console.WriteLine($"Amazing job {name}! You scored {score}/10, fantastic! ");//if the user gets anything higher they pass
            }

           Console.Write("\nWould you like to play again? (Y/N): ");
            string retry = Console.ReadLine().ToUpper();

            //while loop that validates the user's input for (Y/N)
            while (retry != "Y" && retry != "N") 
            {
                Console.Write($"\n{retry} is not a valid choice. Please choose between (Y/N): ");
                retry = Console.ReadLine().ToUpper();
            }

            switch(retry)
            {
                //if the user chooses "Y" it will return to the menu method and repeat the whole quiz
                case "Y": 
                    Console.Clear();
                    menu(name);
                    break;
                //if the user chooses "N" a goodbye message will appear and will thank the use for playing  and end the quiz
                case "N":
                    Console.WriteLine($"\nGoodbye {name}! Thank you for playing!");
                    break;
            }
        
        
        }//end of easy method

        static void Medium(string name)
        {//start of medium method

            Console.Clear();// Clears the menu after the user selects a difficulty and displays the instructions
            Console.WriteLine("This is a 5 question multiple choice quiz. Please Choose an answer between A-D.");
            Console.WriteLine("Your score and the ammount of questions you have left will be displayed on the top left side of the test.");
            Console.WriteLine("\n\t\t\t\t\t-----PRESS ANY KEY TO CONTINUE-----");
            Console.ReadKey();//makes the user press a key before continuing the test
            Console.Clear();

            //stores all of the medium questions
            string[] MedQ = new string[5];
            MedQ[0] = "\nWhat is the traditional Maori greeting?\nA. Kia ora\r\nB. Haere mai\r\nC. Whakapapa\r\nD. Tino rangatiratanga";
            MedQ[1] = "\nWhat is the name of the Maori cultural dance?\nA. Haka\r\nB. Waiata\r\nC. Karakia\r\nD. Kapa haka";
            MedQ[2] = "\nWhich famous Maori leader signed the Treaty of Waitangi on behalf of the Maori people in 1840?\nA. Te Rauparaha\r\nB. Te Wherowhero\r\nC. Te Puea Herangi\r\nD. Hone Heke";
            MedQ[3] = "\nWhat is the traditional Maori method of cooking food using heated rocks in a pit?\nA. Hapū\r\nB. Hangi\r\nC. Hui\r\nD. Haka";
            MedQ[4] = "\nWhat is the name of the Maori goddess of the sea?\nA. Hine-nui-te-pō\r\nB. Tawhiri-mātea\r\nC. Tangaroa\r\nD. Rongo-mai";

            string[] MedA = new string[5];
            MedA[0] = "A";
            MedA[1] = "D";
            MedA[2] = "B";
            MedA[3] = "B";
            MedA[4] = "C";

            string user_ans;
            int score = 0;
            int Qnum = 1;

            for (int i  = 0; i < 5; i++)//loops through all the questions by 5
            {//start of for loop
                Console.WriteLine($"Score:{score}");//displays the score
                Console.WriteLine($"Question {Qnum}");// displays the question number
                Console.WriteLine(MedQ[i]);//displays the question and choices
                Console.Write("Please choose an answer: ");
                user_ans = Console.ReadLine().ToUpper();

                //while loop validating the choices and will display an error message
                while (user_ans != "A" && user_ans != "B" && user_ans != "C" && user_ans != "D")
                {//start of while loop
                    Console.Write($"\n{user_ans} is not a valid choice. Please choose between A-D:");
                    user_ans = Console.ReadLine().ToUpper();
                }//end of while loop

                if (user_ans.Contains(MedA[i]))//if loop that contains the array for the answers and will determine if the answer is correct
                {
                    //if the answer is correct it will display this message
                    Console.WriteLine($"\nGood job {name}! That was the correct answer <3");
                    score = score + 2;

                }
                else if (user_ans != MedA[i])
                {
                   //if the answer is wrong it will display this message
                    Console.WriteLine($"\nNice try {name}! The correct answer was {MedA[i]}");

                }

                Console.WriteLine("\n\t\t\t\t------PRESS ANY KEY TO CONTINUE------");
                Console.ReadKey();
                Qnum++;
                Console.Clear();
            }//end of for loop


            
            //if statement determining the passing score for the quiz
            if (score <= 6)
            {
                Console.WriteLine($"Good effort {name}! You scored {score}/10, so close!");//if the user gets 6 below they fail
            }
            else if (score >= 8)
            {
                Console.WriteLine($"Amazing job {name}! You scored {score}/10, fantastic! ");//if the user gets anything higher they pass
            }

            Console.Write("\nWould you like to try again? (Y/N): ");
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
                //if the user chooses "N" a goodbye message will appear and will thank the user for playing and end the quiz.
                case "N":
                    Console.WriteLine($"\nGoodbye {name}! Thank you for playing!");
                    break;
            }



        }//end of medium method
            

        static void Hard(string name)
        {//start of hard method
           
            Console.Clear();// Clears the menu after the user selects a difficulty and displays the instructions
            Console.WriteLine("This is a 5 question multiple choice quiz. Please Choose an answer between A-D.");
            Console.WriteLine("Your score and the ammount of questions you have left will be displayed on the top left side of the test.");
            Console.WriteLine("\n\t\t\t\t\t-----PRESS ANY KEY TO CONTINUE-----");
            Console.ReadKey();//makes the user press a key before continuing the test
            Console.Clear();

            //stores all of the hard questions in an array
            string[] HardQ = new string[5];
            HardQ[0] = "\nWhat is the name of the sacred Maori mountain located in the central North Island of New Zealand\nA. Taranaki\r\nB. Tongariro\r\nC. Aoraki\r\nD. Ruapehu";
            HardQ[1] = "\nWhat is the name of the Maori language commission responsible for promoting and protecting the Maori language in New Zealand?\nA. Te Puni Kokiri\r\nB. Te Taura Whiri i te Reo Maori\r\nC. Te Mangai Paho\r\nD. Te Whakakitenga Maori";
            HardQ[2] = "\nWhat is the name of the Maori goddess of the forest?\nA. Hine-nui-te-po\r\nB. Tane Mahuta\r\nC. Papatuanuku\r\nD. Ranginui";
            HardQ[3] = "\nWhat is the name of the traditional Maori art form that involves the carving of wood or stone?\r\nA. Whakairo\r\nB. Raranga\r\nC. Ta moko\r\nD. Kapa haka";
            HardQ[4] = "\nWhat is the name of the famous Maori leader who led the Taranaki iwi during the New Zealand Wars of the 1860s\r\nA. Te Rauparaha\r\nB. Wiremu Kingi\r\nC. Te Whiti o Rongomai\r\nD. Hone Heke";


            int score = 0;
            string user_ans;
           

                case "2"://medium difficulty
                    questions = { "\nWhat is the traditional Maori greeting?\nA. Kia ora\r\nB. Haere mai\r\nC. Whakapapa\r\nD. Tino rangatiratanga", "\nWhat is the name of the Maori cultural dance?\nA. Haka\r\nB. Waiata\r\nC. Karakia\r\nD. Kapa haka", "\nWhich famous Maori leader signed the Treaty of Waitangi on behalf of the Maori people in 1840?\nA. Te Rauparaha\r\nB. Te Wherowhero\r\nC. Te Puea Herangi\r\nD. Hone Heke", "\nWhat is the traditional Maori method of cooking food using heated rocks in a pit?\nA. Hapū\r\nB. Hangi\r\nC. Hui\r\nD. Haka", "\nWhat is the name of the Maori goddess of the sea?\nA. Hine-nui-te-pō\r\nB. Tawhiri-mātea\r\nC. Tangaroa\r\nD. Rongo-mai"};
                    answers = {"A", "D", "B", "B", "C"};
                    break
                case "3"://hard difficulty
                    questions = { "\nWhat is the name of the sacred Maori mountain located in the central North Island of New Zealand\nA. Taranaki\r\nB. Tongariro\r\nC. Aoraki\r\nD. Ruapehu", "\nWhat is the name of the Maori language commission responsible for promoting and protecting the Maori language in New Zealand?\nA. Te Puni Kokiri\r\nB. Te Taura Whiri i te Reo Maori\r\nC. Te Mangai Paho\r\nD. Te Whakakitenga Maori", "\nWhat is the name of the Maori goddess of the forest?\nA. Hine-nui-te-po\r\nB. Tane Mahuta\r\nC. Papatuanuku\r\nD. Ranginui", "\nWhat is the name of the traditional Maori art form that involves the carving of wood or stone?\r\nA. Whakairo\r\nB. Raranga\r\nC. Ta moko\r\nD. Kapa haka", "\nWhat is the name of the famous Maori leader who led the Taranaki iwi during the New Zealand Wars of the 1860s\r\nA. Te Rauparaha\r\nB. Wiremu Kingi\r\nC. Te Whiti o Rongomai\r\nD. Hone Heke"};
                    answers = { "B", "B", "B", "A", "C"}
            }//end of swtich loop

            for(int i = 0; i < 5; i++)//loops through all of the questions by 5
            {//start of for loop
                Console.WriteLine($"Score:{score}");//displays the score
                Console.WriteLine($"Question {i++}");//displays the question number
                Console.WriteLine(HardQ[i]);//displays the quesstion and choices
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
                    Console.WriteLine($"\nNice try {name}! The correct answer was {HardA[i]}");
                    
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


            Console.Write("\nWould you like to try again? (Y/N): ");
            string retry = Console.ReadLine().ToUpper();

            //while loop that validates the user's input for (Y/N)
            while (retry != "Y" && retry != "N")
            {//start of while loop
                Console.Write($"\n{retry} is not a valid choice. Please choose between (Y/N): ");
                retry = Console.ReadLine().ToUpper();
            }//end of while loop

            switch (retry)
            {//start of switch loop
                //if the user chooses "Y" it will return to the menu method and repeat the whole quiz
                case "Y":
                    Console.Clear();
                    menu(name);
                    break;
                //if the user chooses "N" a goodbye message will appear and will thank the user for playing and end the quiz.
                case "N":
                    Console.WriteLine($"\nGoodbye {name}! Thank you for playing!");
                    break;
            }//end of switch loop



    }
} 
