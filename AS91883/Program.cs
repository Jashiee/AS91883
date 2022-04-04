/* Introduction*/
int selection;
string answer;
string again;
int score = 0;
Start:
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
while(answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "A" || answer == "a" )
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
    while(answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    Console.WriteLine("If you would like to take the quiz again please type 'y' for yes or just press any key to exit.");
    again = Console.ReadLine();
    Console.Clear();
    if (again == "y" || again == "Y")
    {
        goto Start;
    }

}
Console.ForegroundColor = ConsoleColor.Green;
if (selection == 2)
{
    Console.WriteLine("YOU CHOSE INTERMEDIATE");
    Console.Clear();
    Console.WriteLine("QUESTION 1:");
    Console.WriteLine("What does the word 'Sea' translate to in Maori?");
    Console.WriteLine("A.Sea \nB.Ocean \nC.Mooana \nD.Moana");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "D" || answer == "d")
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
    Console.WriteLine("What does the word 'Walk' translate to in Maori?");
    Console.WriteLine("A.Hikoi \nB.Hike \nC.Run \nD.Hukio");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "a" || answer == "A")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 3:");
    Console.WriteLine("What does the word 'Prayer' translate to in Maori?");
    Console.WriteLine("A.Mahi \nB.Koha \nC.Karakia  \nD.Prayer");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 4:");
    Console.WriteLine("What does the word 'Mountain' translate to in Maori?");
    Console.WriteLine("A.Mahi \nB.Maunga \nC.Mountaino  \nD. Maunga");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 5:");
    Console.WriteLine("What does the word 'Motu' translate to in Englsih?");
    Console.WriteLine("A.Area \nB.Place \nC.Land  \nD.Island");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 6:");
    Console.WriteLine("What does the word 'Children' translate to in Maori?");
    Console.WriteLine("A.Tamaarikii \nB.Tamariki \nC.Children  \nD. Childe");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 7:");
    Console.WriteLine("What does the word 'Funreal' translate to in Maori?");
    Console.WriteLine("A.Tangi \nB.Hui \nC.Tungi  \nD. Tamaaki");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    Console.WriteLine("QUESTION 8:");
    Console.WriteLine("What does the word 'Water' translate to in Maori?");
    Console.WriteLine("A.Waterno \nB.Water \nC.Wai  \nD.Waiata");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 9:");
    Console.WriteLine("What does the word 'Song' translate to in Maori?");
    Console.WriteLine("A.Chant \nB.Song \nC.Wai  \nD.Waiata");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 10:");
    Console.WriteLine("What does the word 'Canoe' translate to in Maori?");
    Console.WriteLine("A.Canoe \nB.Waka \nC.Baot  \nD.Waika");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("your score is  " + (score) + "/10");
    Console.WriteLine("If you would like to take the quiz again please type 'y' for yes or just press any key to exit.");
    again = Console.ReadLine();
    Console.Clear();
    if (again == "y" || again == "Y")
    {
        goto Start;
    }
}
Console.ForegroundColor = ConsoleColor.DarkRed;
if (selection == 3)
{
    Console.WriteLine("YOU CHOSE ADVANCED");
    Console.WriteLine("QUESTION 1:");
    Console.WriteLine("What does the word 'Awesome' translate to in Maori?");
    Console.WriteLine("A.Tau ke \nB.Ka Paie \nC.Awesome \nD.He Reka");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
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
    Console.WriteLine("What does the word 'Wicked' translate to in Maori?");
    Console.WriteLine("A.He Reka \nB.Whakapapa \nC.Wananei \nD.Me Haere");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 3:");
    Console.WriteLine("What does the word 'Look' translate to in Maori?");
    Console.WriteLine("A.He Reka \nB.Haerea \nC.Titiro \nD.Taunga");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "c" || answer == "C")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 4:");
    Console.WriteLine("What does the word 'Toilet' translate to in Maori?");
    Console.WriteLine("A.Whare Pako \nB.Whare Paku \nC.Whare Paki \nD.Whare Lu");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "b" || answer == "B")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 5:");
    Console.WriteLine("What does the word 'Heart' translate to in Maori?");
    Console.WriteLine("A.Ringa \nB.Ihu \nC.Manawa \nD.Arero");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "c" || answer == "C")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 6:");
    Console.WriteLine("What does the word 'Christmas' translate to in Maori?");
    Console.WriteLine("A.Kirihimete  \nB.Hararei \nC.Hakari \nD.Whakanui");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "a" || answer == "A")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 7:");
    Console.WriteLine("What does the word 'Blood Relation' translate to in Maori?");
    Console.WriteLine("A.Wahine  \nB.Tuahine \nC.Whakapapa \nD.Whanaunga");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "d" || answer == "D")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();

    }
    Console.WriteLine("QUESTION 8:");
    Console.WriteLine("What does the word 'Auckland' translate to in Maori?");
    Console.WriteLine("A.Tamaki Makaurau  \nB.Taamakai \nC.Tamaki \nD.Makauauro");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "a" || answer == "A")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 9:");
    Console.WriteLine("What does the word 'Damp' translate to in Maori?");
    Console.WriteLine("A.Waipuke  \nB.Hukarere \nC.Makuku \nD.Hukapapa");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "C" || answer == "c")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("QUESTION 10:");
    Console.WriteLine("What does the word 'Colleague' translate to in Maori?");
    Console.WriteLine("A.Peke  \nB.Hoamahi \nC.Kaitono \nD.Tomokanga");
    answer = Console.ReadLine();
    while (answer != "d" && answer != "c" && answer != "a" && answer != "b" && answer != "D" && answer != "C" && answer != "A" && answer != "B")
    {
        Console.WriteLine("Please enter a vailid input.");
        answer = Console.ReadLine();
    }
    Console.Clear();
    if (answer == "b" || answer == "B")
    {
        Console.WriteLine("Correct!");
        score = score + 1;
    }
    else
    {
        Console.WriteLine("Incorrect");
        Console.Beep();
    }
    Console.WriteLine("your score is  " + (score) + "/10");
    Console.WriteLine("If you would like to take the quiz again please type 'y' for yes or just press any key to exit.");
    again = Console.ReadLine();
    Console.Clear();
    if (again == "y" || again == "Y")
    {
        goto Start;
    }
}
Console.ResetColor();