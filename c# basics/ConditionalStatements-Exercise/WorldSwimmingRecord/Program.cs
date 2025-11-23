double record = double.Parse(Console.ReadLine());
double meters = double.Parse(Console.ReadLine());
double seconds = double.Parse(Console.ReadLine());
double time = meters * seconds;
double slow = Math.Floor(meters / 15) * 12.5;
double combinedTime = time + slow;
if (combinedTime < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {combinedTime:f2} seconds.");
}
else
{
    double timeNeeded = combinedTime - record;
    Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
}