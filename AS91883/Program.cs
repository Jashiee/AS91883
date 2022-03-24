/* Introduction*/
int selection;
string a,b,c,d;
string answer;
Console.WriteLine("Hello There! This is a Te Reo Maori Quiz. The quiz will be multichoice!");
Console.WriteLine("There are 3 different modes.");
// QUIZ SELECTOR//
Console.WriteLine("Please type which mode you would like to do by either typing \n1. for BEGINNER \n2. for INTERMEDIATE \n3. for ADVANCED");
selection = Convert.ToInt32(Console.ReadLine());
while (!int.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection >=4)
{
 Console.WriteLine("PLEASE ENTER A VAILD NUMBER FROM THE LIST PROVIDED");
}

if (selection == 1) 
{
 Console.WriteLine("YOU CHOSE BEGINNER");
 Console.WriteLine("QUESTION 1:");
 Console.WriteLine("What does the word Kia Ora translate to in English?");
 Console.WriteLine("A.Hello \nB.Hola \nC.Good Job \nD.Yes");
 answer = Console.ReadLine();
if (answer == "A" || answer == "a")
    {
        Console.WriteLine("Correct!");
    }
else
    {
        Console.WriteLine("Incorrect");
    }
 Console.WriteLine("QUESTION 2:");
    Console.WriteLine("What does the word 'LOVE' mean in Maori");
    Console.WriteLine("\nA.Love \nB.Aroha \nC.Ka Pai \nD.Whanau");
    answer = Console.ReadLine();
    if (answer == "B" || answer == "b")
    {
        Console.WriteLine("Correct");
    }
  else
    {
        Console.WriteLine("Incorrect");
    }
    Console.WriteLine("QUESTION 3:");
    Console.WriteLine("What does the word 'Family' translate to in Maori?");
    Console.WriteLine("A.Family \nB.Ka Pai \nC.Whanau \nD.No");
    answer = Console.ReadLine();
    if (answer == "c" || answer == "C")
    {
        Console.WriteLine("Correct");
    }
    else 
    {
        Console.WriteLine("Incorrect"); 
    }
    Console.WriteLine("QUESTION 4:");
    Console.WriteLine("What does the word 'hate' translate to in Maori?");
    Console.WriteLine("A.Grape \nB.Hate \nC.Yes \nD.Mauahara");
    answer = Console.ReadLine();
    if (answer == "D" || answer == "d")
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Incorrect");
    }
    if (selection == 2)
    {
        Console.WriteLine("YOU CHOSE INTERMEDIATE");
        
    }
    if (selection == 3)
    {
    Console.WriteLine("YOU CHOSE ADVANCED");
}
