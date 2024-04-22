Console.WriteLine(" tuled voi lahed? (in/out):*");

string usechoice = Console.ReadLine();
if (usechoice == "in")
{
    printhello();

}
else
{
    printGoodBye();

}


static void printhello()
{
    Console.WriteLine("yo");
}

static void printGoodBye()
{
    Console.WriteLine("n2eme");
}