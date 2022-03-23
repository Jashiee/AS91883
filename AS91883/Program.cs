/* Introduction*/
int selection;
string a,b,c,d;
string answer;
Console.WriteLine("Hello There! This is a Te Reo Maori Quiz. The quiz will be multichoice!");
Console.WriteLine("There are 3 different modes.");
// QUIZ SELECTOR//
Console.WriteLine("Please type which mode you would like to do by either typing \n.1 for BEGINNER \n2. for INTERMEDIATE \n3. for ADVANCED");
selection = Convert.ToInt32(Console.ReadLine());
 while (!int.TryParse(Console.ReadLine(), selection != "1" || selection != "2" || selection != "3") 
{
 Console.WriteLine("PLEASE ENTER A VAILD NUMBER FROM THE LIST PROVIDED");
}

if (selection == "1") 
{
 Console.WriteLine("YOU CHOSE BEGINNER");
 Console.WriteLine("QUESTION 1:");
 Console.WriteLine("What does the word Kia Ora translate to in English?");
 Console.WriteLine(A.Hello \nB.Hola \nC.Good Job \nD.Yes");
 answer = Console.ReadLine());
 if (answer == "A" || answer == "a")
                   {
                    Console.WriteLine
}
If (selection == "2") 
{
 Console.WriteLine("YOU CHOSE INTERMEDIATE");
}
if (selection == "3")
{
Console.WriteLine("YOU CHOSE ADVANCED")'
}
