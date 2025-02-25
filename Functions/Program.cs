
Console.WriteLine("Are you comingg or leaving? (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    printGoodBye();
}


static void PrintHello() //function / method (läheb tegusõna)
{
    Console.WriteLine("Hello, world!");
}

static void printGoodBye()
{
    Console.WriteLine("See you later, aligator");
}