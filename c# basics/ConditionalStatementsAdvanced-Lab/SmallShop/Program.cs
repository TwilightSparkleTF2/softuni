string product = Console.ReadLine();
string city = Console.ReadLine();
double amount = double.Parse(Console.ReadLine());
double sum=  0;
double coffee = 0;
double water = 0;
double beer = 0;
double sweets = 0;
double peanuts = 0;


switch (city)
{
    case "Sofia":
        coffee = 0.5;
        water = 0.8;
        beer = 1.2;
        sweets = 1.45;
        peanuts = 1.60;
        break;
    case "Plovdiv":
        coffee = 0.4;
        water = 0.7;
        beer = 1.15;
        sweets = 1.3;
        peanuts = 1.5;
        break;
    case "Varna":
        coffee = 0.45;
        water = 0.7;
        beer = 1.1;
        sweets = 1.35;
        peanuts = 1.55;
        break;
}

switch (product)
{

    case "coffee":
        sum = amount * coffee;
        break;
    case "water":
        sum = amount * water;
        break;
    case "beer":
        sum = amount * beer;
        break;
    case "sweets":
        sum = amount * sweets;
        break;
    case "peanuts":
        sum = amount * peanuts;
        break;
}

Console.WriteLine(sum);