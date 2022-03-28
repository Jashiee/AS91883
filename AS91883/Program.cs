/* Introduction*/
int selection;
string a,b,c,d;
string answer;
string[] MaoriWordsEasy = { "Kia Ora", "Aroha", " Family", "Mauahara", "Ahau", "Morena", "Hui", "Kai", "iwi", "moa" };
string[] EnglsihWordsEasy = { "Hello", "Love", "Whanau", "Hate", "Me", "Good Morning", "gathering", "food", "Tribe", "flightless bird" };
int score = 0;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Hello There! This is a Te Reo Maori Quiz. The quiz will be multichoice!");
Console.WriteLine("There are 3 different modes.");
// QUIZ SELECTOR//
Console.WriteLine("Please type which mode you would like to do by either typing \n1. for BEGINNER \n2. for INTERMEDIATE \n3. for ADVANCED");
while (!int.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection >=4)
{
 Console.WriteLine("PLEASE ENTER A VAILD NUMBER FROM THE LIST PROVIDED");
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
if (selection == 1) 
{
 Console.WriteLine("YOU CHOSE BEGINNER");
 Console.WriteLine("QUESTION 1:");
 Console.WriteLine("What does the word Kia Ora translate to in English?");
 Console.WriteLine("A.Hello \nB.Hola \nC.Good Job \nD.Yes");
 answer = Console.ReadLine();
    Console.Clear();
    if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();

    }
 Console.WriteLine("QUESTION 2:");
    Console.WriteLine("What does the word 'LOVE' mean in Maori");
    Console.WriteLine("\nA.Love \nB.Aroha \nC.Ka Pai \nD.Whanau");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
  else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 3:");
    Console.WriteLine("What does the word 'Family' translate to in Maori?");
    Console.WriteLine("A.Family \nB.Ka Pai \nC.Whanau \nD.No");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "c" || answer == "C")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
    else 
    {
        Console.WriteLine("Incorrect" );
        Console.Beep();
    }
    Console.WriteLine("QUESTION 4:");
    Console.WriteLine("What does the word 'hate' translate to in Maori?");
    Console.WriteLine("A.Grape \nB.Hate \nC.Yes \nD.Mauahara");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "d" || answer == "D")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }

    Console.WriteLine("QUESTION 5:");
    Console.WriteLine("What does the word 'Me' translate to in Maori?");
    Console.WriteLine("A.Ka Pai \nB.Ahau \nC.Me \nD.You");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "b" || answer == "B")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 6:");
    Console.WriteLine("What does the word 'Good Morning' translate to in Maori?");
    Console.WriteLine("A.Hola \nB.Good Moreno \nC. Morning \nD.Morena");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "d" || answer == "D")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 7:");
    Console.WriteLine("What does the word 'Meeting' translate to in Maori?");
    Console.WriteLine("A.Hola \nB.Meeting \nC. Hui \nD.Mama");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
 
    Console.WriteLine("QUESTION 8:");
    Console.WriteLine("What does the word 'Food' translate to in Maori?");
    Console.WriteLine("A.Yes \nB.Kai \nC. food \nD.Kapi");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "b" || answer == "B")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 9:");
    Console.WriteLine("What does the word 'Tribe' translate to in Maori?");
    Console.WriteLine("A.Iwi \nB.Tribe \nC. Whanau \nD.Mama");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "a" || answer == "A")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 10:");
    Console.WriteLine("What does the word 'Flightless bird' translate to in Maori?");
    Console.WriteLine("A.Mua \nB.Bird \nC.Birdy \nD.Moa");
    answer = Console.ReadLine();
    Console.Clear();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("your score is  " + (score) + "/10");




}
Console.ForegroundColor = ConsoleColor.Green;
if (selection == 2)
    {
        Console.WriteLine("YOU CHOSE INTERMEDIATE");
        
    }
Console.ForegroundColor = ConsoleColor.DarkRed;
if (selection == 3)
    {
    Console.WriteLine("YOU CHOSE ADVANCED");
}
