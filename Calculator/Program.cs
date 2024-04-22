using System.Numerics;

Console.WriteLine("kirja arvutus(+/-):*");

char useroperator = char.Parse(Console.ReadLine());
Console.WriteLine(" pane a:");
int firstnum = Int32.Parse(Console.ReadLine());
Console.WriteLine("pane b:");
int secondnum = Int32.Parse(Console.ReadLine());

switch (useroperator)
{
    case '+':
        addition(firstnum, secondnum);
            break;
    case '-':
        subtraction(firstnum, secondnum);
        break;
    default:
        Console.WriteLine("vale tehe");
        break;

        

}

static void addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");

}

static void subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}
