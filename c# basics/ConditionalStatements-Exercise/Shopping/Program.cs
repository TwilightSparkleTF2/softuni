double budget = double.Parse(Console.ReadLine());
int videocards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());
double videocardPrice = 250;
double processorPrice = (videocardPrice * videocards) * 0.35;
double ramPrice = (videocardPrice * videocards) * 0.1;
double sum = (videocardPrice * videocards) + (processorPrice * processors) + (ramPrice * ram);
if (videocards > processors)
{
    sum = sum - (sum * 0.15);
}
if (sum <= budget)
{
    double moneyLeft = budget - sum;
    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
}
else
{
    double moneyNeeded = sum - budget;
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
}