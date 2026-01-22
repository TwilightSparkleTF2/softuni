string month = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double sumStudio = 0;
double sumApartment = 0;

switch (month)
{
    case "May":
        sumStudio = days * 50;
        sumApartment = days * 65;
        break;
    case "October":
        sumStudio = days * 50;
        sumApartment = days * 65;
        break;
    case "June":
        sumStudio = days * 75.20;
        sumApartment = days * 68.70;
        break;
    case "September":
        sumStudio = days * 75.20;
        sumApartment = days * 68.70;
        break;
    case "July":
        sumStudio = days * 76;
        sumApartment = days * 77;
        break;
    case "August":
        sumStudio = days * 76;
        sumApartment = days * 77;
        break;
}

if ((month == "May" || month == "October") && days > 14) //placements of ifs matters, always start with the biggest discount
{
    sumStudio = sumStudio * 0.7;
}

else if ((month == "May" || month == "October") && days > 7)
{
    sumStudio = sumStudio * 0.95;
}

else if ((month == "June" || month == "September") && days > 14)
{
    sumStudio = sumStudio * 0.8;
}

if (days > 14) //not an else if, because it would never be true unless everything else if false
{
    sumApartment = sumApartment * 0.9;
}

Console.WriteLine($"Apartment: {sumApartment:f2} lv.");
Console.WriteLine($"Studio: {sumStudio:f2} lv.");