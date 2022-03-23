/* Introduction*/
int selection;
Console.WriteLine("Hello There! This is a Te Reo Maori Quiz. The quiz will be multichoice!");
Console.WriteLine("There are 3 different modes.");
// QUIZ SELECTOR//
Console.WriteLine("Please type which mode you would like to do by either typing \n.1 for BEGINNER \n2. for INTERMEDIATE \n3. for ADVANCED");
selection = Convert.ToInt32(Console.ReadLine());
string selectionResult = selection.ToLower();
if (selectionResult != "beginner"|| selectionResult != "medium" || selectionResult != "hard")
{
    Console.WriteLine("No");
}
    if (selectionResult == "beginner" || selectionResult == "BEGGINNER" || selectionResult == "begginer")
    {
        Console.WriteLine("YOU CHOSE BEGINNER");
    }
    else if (selectionResult == "medium")
    {
        Console.WriteLine("YOU CHOSE MEDIUM");
    }
    else if (selectionResult == "hard")
    {
        Console.WriteLine("YOU CHOSE HARD");
    }
 while (!int.TryParse(Console.ReadLine(), ))
