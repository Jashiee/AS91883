namespace AS91883
{
    class TeReoMaoriQuiz
    {
        public static void Main()
        {
            int selection;
            /* Introduction*/
            Console.WriteLine("Hello There! This is a Te Reo Maori Quiz. The quiz will be multichoice!");
            Console.WriteLine("There are 3 different modes.");
            // QUIZ SELECTOR//- The user is given options here so they can choose which mode they would like to do/
            Console.WriteLine("Please type which mode you would like to do by either typing\n\n1. for BEGINNER\n\n2. for INTERMEDIATE\n\n3. for ADVANCED \nJust Input The Number Next To The Option To Continue To That Stage.");
            while (!int.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection >= 4)
            {
                Console.WriteLine("PLEASE ENTER A VAILID NUMBER FROM THE LIST PROVIDED");
            }
            Console.Clear(); // clears the console, so it doesnt crowd up//
            if (selection == 1) // This if statement gets the users input and then directs the user to the level they have chosen//
            {
                Beginner(); //Method for Beginner Level//
            }
            if (selection == 2)
            {
                Intermediate(); //Method for Intermediate Level//
            }
            if (selection == 3)
            {
                Advanced(); //Method for Advanced Level//
            }
        }
        public static void Beginner()
        {
            string answer;
            int score = 0;
            string again;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("YOU CHOSE BEGINNER");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("QUESTION 1:");
            Console.WriteLine("What does the word Hello translate to in Maori?");
            Console.WriteLine("\nA.Kia Ora\n\nB.Hola\n\nC.Good Job\n\nD.Yes");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B") // If user inputs something else than A B C or D, the console will display a error message.
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "A" || answer == "a") // This checks if the answer is correct, if the answer is correct it will display a message saying 'correct'//
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 2:");
            Console.WriteLine("What does the word 'LOVE' mean in Maori");
            Console.WriteLine("\nA.Love\n\nB.Aroha\n\nC.Ka Pai\n\nD.Whanau");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear(); // Clears the console, removing other questions so that the user does not have to scroll down//
            if (answer == "B" || answer == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 3:");
            Console.WriteLine("What does the word 'Family' translate to in Maori?");
            Console.WriteLine("\nA.Family\n\nB.Ka Pai\n\nC.Whanau\n\nD.No");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "c" || answer == "C")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 4:");
            Console.WriteLine("What does the word 'hate' translate to in Maori?");
            Console.WriteLine("\nA.Grape\n\nB.Hate\n\nC.Yes\n\nD.Mauahara");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "d" || answer == "D")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 5:");
            Console.WriteLine("What does the word 'Me' translate to in Maori?");
            Console.WriteLine("\nA.Ka Pai\n\nB.Ahau\n\nC.Me\n\nD.You");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "b" || answer == "B")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 6:");
            Console.WriteLine("What does the word 'Good Morning' translate to in Maori?");
            Console.WriteLine("\nA.Hola\n\nB.Good Moreno\n\nC.Morning\n\nD.Morena");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "d" || answer == "D")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 7:");
            Console.WriteLine("What does the word 'Meeting' translate to in Maori?");
            Console.WriteLine("\nA.Hola\n\nB.Meeting\n\nC.Hui\n\nD.Mama");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "C" || answer == "c")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 8:");
            Console.WriteLine("What does the word 'Food' translate to in Maori?");
            Console.WriteLine("\nA.Yes\n\nB.Kai\n\nC.Food\n\nD.Kapi");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "b" || answer == "B")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 9:");
            Console.WriteLine("What does the word 'Tribe' translate to in Maori?");
            Console.WriteLine("\nA.Iwi\n\nB.Tribe\n\nC.Whanau\n\nD.Mama");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "a" || answer == "A")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 10:");
            Console.WriteLine("What does the word 'Flightless bird' translate to in Maori?");
            Console.WriteLine("\nA.Mua\n\nB.Bird\n\nC.Birdy\n\nD.Moa");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "D" || answer == "d")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("Your score is  " + (score) + "/10"); // Displays the users score from throughout the program, this is for every correct question they get//
            EndProgram();
        }
        public static void Intermediate()
        {
            string answer;
            int score = 0;
            string again;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("YOU CHOSE INTERMEDIATE");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("QUESTION 1:");
            Console.WriteLine("What does the word 'Sea' translate to in Maori?");
            Console.WriteLine("\nA.Sea\n\nB.Ocean\n\nC.Mooana\n\nD.Moana");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "D" || answer == "d")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 2:");
            Console.WriteLine("What does the word 'Walk' translate to in Maori?");
            Console.WriteLine("\nA.Hikoi\n\nB.Hike\n\nC.Run\n\nD.Hukio");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "a" || answer == "A")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 3:");
            Console.WriteLine("What does the word 'Prayer' translate to in Maori?");
            Console.WriteLine("\nA.Mahi\n\nB.Koha\n\nC.Karakia \n\nD.Prayer");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "C" || answer == "c")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 4:");
            Console.WriteLine("What does the word 'Mountain' translate to in Maori?");
            Console.WriteLine("\nA.Mahi\n\nB.Maunga\n\nC.Mountaino \n\nD. Maunga");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "C" || answer == "c")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 5:");
            Console.WriteLine("What does the word 'Motu' translate to in Englsih?");
            Console.WriteLine("\nA.Area\n\nB.Place\n\nC.Land \n\nD.Island");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "D" || answer == "d")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 6:");
            Console.WriteLine("What does the word 'Children' translate to in Maori?");
            Console.WriteLine("\nA.Tamaarikii\n\nB.Tamariki\n\nC.Children \n\nD. Childe");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "C" || answer == "c")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 7:");
            Console.WriteLine("What does the word 'Funreal' translate to in Maori?");
            Console.WriteLine("\nA.Tangi\n\nB.Hui\n\nC.Tungi \n\nD.Tamaaki");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "A" || answer == "a")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 8:");
            Console.WriteLine("What does the word 'Water' translate to in Maori?");
            Console.WriteLine("\nA.Waterno\n\nB.Water\n\nC.Wai \n\nD.Waiata");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "C" || answer == "c")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 9:");
            Console.WriteLine("What does the word 'Song' translate to in Maori?");
            Console.WriteLine("\nA.Chant\n\nB.Song\n\nC.Wai \n\nD.Waiata");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "D" || answer == "d")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 10:");
            Console.WriteLine("What does the word 'Canoe' translate to in Maori?");
            Console.WriteLine("\nA.Canoe\n\nB.Waka\n\nC.Baot \n\nD.Waika");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "B" || answer == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("Your Score is  " + (score) + "/10");
            EndProgram();
        }
        public static void Advanced() //if user inputed 3, they will be taken to the advanced level quiz.
        {
            string answer;
            int score = 0;
            string again;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("YOU CHOSE ADVANCED");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("QUESTION 1:");
            Console.WriteLine("What does the word 'Awesome' translate to in Maori?");
            Console.WriteLine("\nA.Tau ke\n\nB.Ka Paie\n\nC.Awesome\n\nD.He Reka");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "A" || answer == "a")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 2:");
            Console.WriteLine("What does the word 'Wicked' translate to in Maori?");
            Console.WriteLine("\nA.He Reka\n\nB.Whakapapa\n\nC.Wananei\n\nD.Me Haere");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "C" || answer == "c")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 3:");
            Console.WriteLine("What does the word 'Look' translate to in Maori?");
            Console.WriteLine("\nA.He Reka\n\nB.Haerea\n\nC.Titiro\n\nD.Taunga");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "c" || answer == "C")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 4:");
            Console.WriteLine("What does the word 'Toilet' translate to in Maori?");
            Console.WriteLine("\nA.Whare Pako\n\nB.Whare Paku\n\nC.Whare Paki\n\nD.Whare Lu");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "b" || answer == "B")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 5:");
            Console.WriteLine("What does the word 'Heart' translate to in Maori?");
            Console.WriteLine("\nA.Ringa\n\nB.Ihu\n\nC.Manawa\n\nD.Arero");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "c" || answer == "C")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 6:");
            Console.WriteLine("What does the word 'Christmas' translate to in Maori?");
            Console.WriteLine("\nA.Kirihimete \n\nB.Hararei\n\nC.Hakari\n\nD.Whakanui");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "a" || answer == "A")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 7:");
            Console.WriteLine("What does the word 'Blood Relation' translate to in Maori?");
            Console.WriteLine("\nA.Wahine \n\nB.Tuahine\n\nC.Whakapapa\n\nD.Whanaunga");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "d" || answer == "D")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();

            }
            Console.WriteLine("QUESTION 8:");
            Console.WriteLine("What does the word 'Auckland' translate to in Maori?");
            Console.WriteLine("\nA.Tamaki Makaurau \n\nB.Taamakai\n\nC.Tamaki\n\nD.Makauauro");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "a" || answer == "A")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 9:");
            Console.WriteLine("What does the word 'Damp' translate to in Maori?");
            Console.WriteLine("\nA.Waipuke \n\nB.Hukarere\n\nC.Makuku\n\nD.Hukapapa");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "C" || answer == "c")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("QUESTION 10:");
            Console.WriteLine("What does the word 'Colleague' translate to in Maori?");
            Console.WriteLine("\nA.Peke \n\nB.Hoamahi\n\nC.Kaitono\n\nD.Tomokanga");
            answer = Console.ReadLine();
            while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
            {
                Console.WriteLine("Please enter a vailid input.");
                answer = Console.ReadLine();
            }
            Console.Clear();
            if (answer == "b" || answer == "B")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score = score + 1; // If the answer is correct, 1 point will be added to score.
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect"); // If the answer is incorrect, a beep sound will be played with a message displaying 'incorrect'.// 
                Console.Beep();
                Console.ResetColor();
            }
            Console.WriteLine("Your Score is  " + (score) + "/10");
            EndProgram();
        }
        public static void EndProgram()
        {
            string again;
            Console.WriteLine("If you would like to take the quiz again please type 'y' for yes or press 'N' for No.");
            again = Console.ReadLine();
            Console.Clear();
            if (again == "y" || again == "Y")
            {
                Main();
            }
            else if (again == "n" || again == "N")
            {
                Console.WriteLine("Thank You for Participating in this Te Reo Maori Quiz. :)");
            }
        }
           
    }
}