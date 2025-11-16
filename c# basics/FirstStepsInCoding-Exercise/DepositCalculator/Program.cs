double depositSum = double.Parse(Console.ReadLine());
double deadline =  double.Parse(Console.ReadLine());
double anualLihvenPercentege  = double.Parse(Console.ReadLine());
double percent = anualLihvenPercentege / 100;
double natrupanaLihva = depositSum * percent;
double LihvaForOneMonth = natrupanaLihva / 12;
double sum = depositSum + deadline * LihvaForOneMonth;
Console.WriteLine(sum);