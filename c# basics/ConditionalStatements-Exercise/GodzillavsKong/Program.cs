double movieBudget = double.Parse(Console.ReadLine());
double numStatisti = double.Parse(Console.ReadLine());
double priceCostumeForStatist = double.Parse(Console.ReadLine());

double decorationSum = 0.1 * movieBudget;
double costumeSum;

if (numStatisti >= 150)
{
    costumeSum = (numStatisti * priceCostumeForStatist) - (numStatisti * priceCostumeForStatist) * 0.1;
}

else
{
    costumeSum = numStatisti * priceCostumeForStatist;
}

double budgetLeft = movieBudget - (costumeSum + decorationSum);
if (budgetLeft < 0)
{
    double needs = (costumeSum + decorationSum) - movieBudget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {needs:f2} leva more.");

}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budgetLeft:F2} leva left.");
}