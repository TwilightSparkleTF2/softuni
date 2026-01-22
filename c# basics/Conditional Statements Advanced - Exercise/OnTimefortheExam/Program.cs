int hourOfExam = int.Parse(Console.ReadLine());
int minutesOfExam = int.Parse(Console.ReadLine());
int hourOnArrival = int.Parse(Console.ReadLine());
int minutesOnArrival = int.Parse(Console.ReadLine());


int examTime = hourOfExam * 60 + minutesOfExam;
int arrivalTime = hourOnArrival * 60 + minutesOnArrival;
int diff = arrivalTime - examTime;

int hours = diff / 60;
int mins = diff % 60;

if (diff > 0)
{
    Console.WriteLine("Late");
    if (hours == 0)
    {
        Console.WriteLine($"{mins} minutes after the start");
    }
    else
    {
        Console.WriteLine($"{hours}:{mins:d2} hours after the start");
    }
}

else if (diff <= 0 && diff >= -30)
{
    Console.WriteLine("On time");
    if (diff != 0)
    {
        Console.WriteLine($"{Math.Abs(mins)} minutes before the start");
    }
}

else
{
    Console.WriteLine("Early");
    if (hours == 0)
    {
        Console.WriteLine($"{Math.Abs(mins)} minutes before the start");
    }
    else
    {
        Console.WriteLine($"{Math.Abs(hours)}:{Math.Abs(mins):d2} hours before the start");
    }
}