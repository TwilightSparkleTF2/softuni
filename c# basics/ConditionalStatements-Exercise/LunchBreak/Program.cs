string seriesName = Console.ReadLine();
int episodeLength = int.Parse(Console.ReadLine());
int breakLength = int.Parse(Console.ReadLine());
double lunchTime = breakLength * 0.125;
double otdihTime = breakLength * 0.25;
double timeLeft = breakLength - lunchTime - otdihTime;
if (timeLeft >= episodeLength)
{
    double freeTime = Math.Ceiling(timeLeft - episodeLength);
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {freeTime} minutes free time.");
}
else
{
    double neededTime = Math.Ceiling(episodeLength - timeLeft);
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {neededTime} more minutes.");
}