string food = Console.ReadLine();
string day = Console.ReadLine();
double amount = double.Parse(Console.ReadLine());
double sum = 0;

double banana = 0;
double apple = 0;
double orange = 0;
double grapefruit = 0;
double kiwi = 0;
double pineapple = 0;
double grapes = 0;

switch (day)
{
    case "Saturday":
    case "Sunday":
        banana = 2.7;
        apple = 1.25;
        orange = 0.9;
        grapefruit = 1.6;
        kiwi = 3;
        pineapple = 5.6;
        grapes = 4.2;
        break;
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        banana = 2.5;
        apple = 1.2;
        orange = 0.85;
        grapefruit = 1.45;
        kiwi = 2.7;
        pineapple = 5.5;
        grapes = 3.85;
        break;
    default:
        Console.WriteLine("error");
        return;
}

switch (food)
{
    case "banana":
        sum = amount * banana;
        Console.WriteLine($"{sum:f2}");
        break;
    case "apple":
        sum = amount * apple;
        Console.WriteLine($"{sum:f2}");
        break;
    case "orange":
        sum = amount * orange;
        Console.WriteLine($"{sum:f2}");
        break;
    case "grapefruit":
        sum = amount * grapefruit;
        Console.WriteLine($"{sum:f2}");
        break;
    case "kiwi":
        sum = amount * kiwi;
        Console.WriteLine($"{sum:f2}");
        break;
    case "pineapple":
        sum = amount * pineapple;
        Console.WriteLine($"{sum:f2}");
        break;
    case "grapes":
        sum = amount * grapes;
        Console.WriteLine($"{sum:f2}");
        break;
    default:
        Console.WriteLine("error");
        break;
}