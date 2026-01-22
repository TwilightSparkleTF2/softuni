const double rose = 5;
const double dahlia = 3.8;
const double tulip = 2.8;
const double narcissus = 3;
const double gladiolus = 2.5;

string flower = Console.ReadLine();
int amount = int.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());
double totalPrice = 0;

switch (flower)
{
    case "Roses":
        totalPrice = amount * rose;
        if (amount > 80)
        {
            totalPrice = (amount * rose) * 0.9;
        }
    break;
    case "Dahlias":
        totalPrice = amount * dahlia;
        if (amount > 90)
        {
            totalPrice = (amount * dahlia) * 0.85;
        }
    break;
    case "Tulips":
        totalPrice = amount * tulip;
        if (amount > 80)
        {
            totalPrice = (amount * tulip) * 0.85;
        }
    break;
    case "Narcissus":
        totalPrice = amount * narcissus;
        if (amount < 120)
        {
            totalPrice = (amount * narcissus) * 1.15;
        }
    break;
    case "Gladiolus":
        totalPrice = amount * gladiolus;
        if (amount < 80)
        {
            totalPrice = (amount * gladiolus) * 1.2;
        }
    break;
}

if (budget >= totalPrice)
{
    double leftover = budget - totalPrice;
    Console.WriteLine($"Hey, you have a great garden with {amount} {flower} and {leftover:F2} leva left.");
}
else
{
    double needed = totalPrice - budget;
    Console.WriteLine($"Not enough money, you need {needed:F2} leva more.");
}