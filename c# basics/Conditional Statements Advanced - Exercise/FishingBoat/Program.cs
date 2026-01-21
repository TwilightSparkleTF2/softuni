int budget = int.Parse(Console.ReadLine());
string season  = Console.ReadLine();
int fishers = int.Parse(Console.ReadLine());
double price = 0;

switch (season)
{
	case "Spring":
		price = 3000;
	break;

	case "Summer":
		price = 4200;
	break;

	case "Autumn":
		price = 4200;
	break;

	case "Winter":
		price = 2600;
	break;
}
if (fishers <= 6)
{
    price = price * 0.9;
}
else if (fishers >= 7 && fishers <= 11)
{
    price = price * 0.85;
}
else
{
    price = price * 0.75;
}

if (fishers % 2 == 0 && season != "Autumn")
{
	price = price * 0.95;
}


if (budget >= price)
{
    double remainingMoney = budget - price;
    Console.WriteLine($"Yes! You have {remainingMoney:F2} leva left.");
}
else
{
	double neededMoney = price - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
}