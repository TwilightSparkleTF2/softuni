int pages = int.Parse(Console.ReadLine());
int pagesReadForAnHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int totalTimeForReading = pages / pagesReadForAnHour;
int needHoursPerDay = totalTimeForReading / days;
Console.WriteLine(needHoursPerDay);