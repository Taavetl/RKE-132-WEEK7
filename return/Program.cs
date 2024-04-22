using System.ComponentModel.Design;

Console.WriteLine("provide total: ");
int userinput = Int32.Parse(Console.ReadLine());

double discount = calculatediscount(userinput);

Console.WriteLine($"your discount is {discount}%");

double newtotal = calculatenewtotal(userinput, discount);

Console.WriteLine($" your updated total with {discount}%: {newtotal}");


static double calculatediscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double calculatenewtotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}