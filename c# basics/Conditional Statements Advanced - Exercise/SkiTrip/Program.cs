int days = int.Parse(Console.ReadLine());
string interior = Console.ReadLine();
string grade = Console.ReadLine();
double sum = 0;
double final = 0;

int nights = days - 1;

switch (interior)
{
	case "room for one person":
		sum = nights * 18;
		break;

	case "apartment":
		sum = nights * 25;
		if (nights < 10)
		{
			sum = sum * 0.7;
		}
		else if (nights >= 10 && nights <= 15)
		{
			sum = sum * 0.65;
		}
		else
		{
			sum = sum * 0.50;
		}
		break;

	case "president apartment":
		sum = nights * 35;
		if (nights < 10)
		{
			sum = sum * 0.9;
		}
		else if (nights >= 10 && nights <= 15)
		{
			sum = sum * 0.85;
		}
		else
		{
			sum = sum * 0.80;
		}
		break;
}

if (grade == "positive")
{
    final = sum + (sum * 25 / 100); //sum*1.25
}
else
{
	final = sum - (sum * 10 / 100); //sum*0.9
}

Console.WriteLine($"{final:f2}");