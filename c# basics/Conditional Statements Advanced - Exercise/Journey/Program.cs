double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string staying = "";
string destination = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    switch (season)
	{
		case "summer":
			budget = budget * 0.3;
			staying = "Camp";
		break;

		case "winter":
			budget = budget * 0.7;
			staying = "Hotel";
		break;
    }
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{staying} - {budget:F2}");
}

else if (budget <= 1000)
{
    destination = "Balkans";
    switch (season)
    {
        case "summer":
            budget = budget * 0.4;
            staying = "Camp";
            break;

        case "winter":
            budget = budget * 0.8;
            staying = "Hotel";
            break;
    }
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{staying} - {budget:F2}");
}

else
{
    destination = "Europe";
    budget = budget * 0.9;
    staying = "Hotel";
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{staying} - {budget:F2}");
}