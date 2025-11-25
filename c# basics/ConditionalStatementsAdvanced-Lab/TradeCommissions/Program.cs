string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());
double sum = 0;

double p1 = 0;
double p2 = 0;
double p3 = 0;
double p4 = 0;

switch (city)
{
	case "Sofia":
		p1 = 0.05 * sales;
		p2 = 0.07 * sales;
		p3 = 0.08 * sales;
		p4 = 0.12 * sales;
		break;
	case "Varna":
        p1 = 0.045 * sales;
        p2 = 0.075 * sales;
        p3 = 0.1 * sales;
        p4 = 0.13 * sales;
		break;
	case "Plovdiv":
        p1 = 0.055 * sales;
        p2 = 0.08 * sales;
        p3 = 0.12 * sales;
        p4 = 0.145 * sales;
		break;
	default:
		Console.WriteLine("error");
		return;
}

if (sales >= 0 && sales <= 500)
{
	sum = p1;
}
else if (sales > 500 && sales <= 1000)
{
	sum = p2;
}
else if (sales > 1000 && sales <= 10000)
{
	sum = p3;
}
else if (sales > 10000)
{
	sum = p4;
}
else
{
	Console.WriteLine("error");
	return;
}

	Console.WriteLine($"{sum:f2}");