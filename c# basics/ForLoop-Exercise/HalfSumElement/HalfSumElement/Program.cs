int count = int.Parse(Console.ReadLine());
int sum = 0;
int max = int.MinValue;
for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;
    if (number > max)
    {
        max = number;
    }
}
int sumWithoutMax = sum - max;
if  (sumWithoutMax == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}
else
{
    int diff = Math.Abs(max - sumWithoutMax);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}