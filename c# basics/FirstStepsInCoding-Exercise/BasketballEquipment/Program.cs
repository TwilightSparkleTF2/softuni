double tax = double.Parse(Console.ReadLine());
double kecovePrice = tax - (0.4 * tax);
double ekipPrice = kecovePrice - (0.2 * kecovePrice);
double ballPrice = 0.25 * ekipPrice;
double acessoriesPrice = 0.20 * ballPrice;
double sum = tax +  kecovePrice + ekipPrice + ballPrice + acessoriesPrice;
Console.WriteLine(sum);