double dulzina = double.Parse(Console.ReadLine());
double shirochina = double.Parse(Console.ReadLine());
double visochina = double.Parse(Console.ReadLine());
double procent = double.Parse(Console.ReadLine());
double obemNaAkvarium = dulzina * shirochina * visochina;
double obemVLitri = obemNaAkvarium / 1000;
double zaetoProstranstovo = procent / 100;
double sum = obemVLitri * (1 - zaetoProstranstovo);
Console.WriteLine(sum);