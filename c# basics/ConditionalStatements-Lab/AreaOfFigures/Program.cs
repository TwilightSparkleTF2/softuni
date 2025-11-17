string type = Console.ReadLine();
if (type == "square")
{
    double a = double.Parse(Console.ReadLine());
    double solution1 = a * a;
    Console.WriteLine(solution1);
}
else if (type == "rectangle")
{
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double solution2 = b * c;
    Console.WriteLine(solution2);
}
else if (type == "circle")
{
    double d = double.Parse(Console.ReadLine());
    double solution3 = Math.PI * d * d;
    Console.WriteLine(solution3);
}
else if (type == "triangle")
{
    double d = double.Parse(Console.ReadLine());
    double e = double.Parse(Console.ReadLine());
    double solution4 = (e * d) / 2;
    Console.WriteLine(solution4);
}