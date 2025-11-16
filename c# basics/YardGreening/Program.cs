double squareKilometer = double.Parse(Console.ReadLine());
double pricePerSQwithDDS = 7.61;
double discountPercentage = 0.18;
double priceWithNoDiscount = squareKilometer * pricePerSQwithDDS;
double discount = discountPercentage * priceWithNoDiscount;
double FinalPrice = priceWithNoDiscount - discount;
Console.WriteLine($"The final price is: {FinalPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");