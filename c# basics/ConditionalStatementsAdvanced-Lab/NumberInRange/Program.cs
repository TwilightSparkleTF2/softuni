int number = int.Parse(Console.ReadLine());
if (number >= 1 && number <= 100)
{
    Console.WriteLine("Yes");
}
else if (number <= -1 && number >= -100)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}