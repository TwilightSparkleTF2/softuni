int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int sumMinutes = minutes + 15;
if (sumMinutes >= 60)
{
    hours += 1;
    minutes = sumMinutes % 60;
    if (hours == 24)
    {
        hours = 0;
    }
    Console.WriteLine($"{hours}:{minutes:d2}");
}
else
{
    minutes = sumMinutes;
    Console.WriteLine($"{hours}:{minutes:d2}");
}