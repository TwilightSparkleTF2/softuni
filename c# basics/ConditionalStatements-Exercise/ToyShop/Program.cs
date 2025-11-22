double tripPrice = double.Parse(Console.ReadLine());
double puzzleCount = double.Parse(Console.ReadLine());
double dollsCount = double.Parse(Console.ReadLine());
double plushiesCount = double.Parse(Console.ReadLine());
double minionsCount = double.Parse(Console.ReadLine());
double trucksCount = double.Parse(Console.ReadLine());
double sum = (puzzleCount * 2.60) + (dollsCount * 3) + (plushiesCount * 4.10) + (minionsCount * 8.20) + (trucksCount * 2);
double toysSum = puzzleCount + dollsCount + plushiesCount + minionsCount + trucksCount;
if (toysSum >= 50)
{
    double discount = sum * 0.25;
    double finalSum = sum - discount;
    double rent = finalSum * 0.1;
    double winnings = finalSum - rent;
    if (winnings >= tripPrice)
    {
        double remaining = winnings - tripPrice;
        Console.WriteLine($"Yes! {remaining:F2} lv left.");
    }
    else
    {
        double remaining = tripPrice - winnings;
        Console.WriteLine($"Not enough money! {remaining:F2} lv needed.");
    }
}
else
{
    double rent = sum * 0.1;
    double winnings = sum - rent;
    if (winnings < tripPrice)
    {
        double remaining = tripPrice - winnings;
        Console.WriteLine($"Not enough money! {remaining:F2} lv needed.");
    }
    else
    {
        double remaining = winnings - tripPrice;
        Console.WriteLine($"Yes! {remaining:F2} lv left.");
    }
}