int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string operatoor = Console.ReadLine();
double sum = 0;

if ((operatoor == "/" || operatoor == "%") && num2 == 0)
{
    Console.WriteLine($"Cannot divide {num1} by zero");
    return;
}

switch (operatoor)
{
    case "+":
        sum = num1 + num2;
        break;

    case "-":
        sum = num1 - num2;
        break;

    case "*":
        sum = num1 * num2;
        break;

    case "/":
        sum = (double)num1 / num2; //this converts it int to a double
        break;

    case "%":
        sum = num1 % num2;
        break;
}

//if (operatoor == "+" || operatoor == "-" || operatoor == "*")
//{
//    string type = (sum % 2 == 0) ? "even" : "odd";
//    Console.WriteLine($"{num1} {operatoor} {num2} = {sum} - {type}");
//}
if (operatoor == "+" || operatoor == "-" || operatoor == "*")
{
    string type = "";

    if (sum % 2 == 0)
    {
        type = "even";
    }
    else
    {
        type = "odd";
    }

    Console.WriteLine($"{num1} {operatoor} {num2} = {sum} - {type}");
}
else if (operatoor == "/")
{
    Console.WriteLine($"{num1} / {num2} = {sum:F2}");
}
else if (operatoor == "%")
{
    Console.WriteLine($"{num1} % {num2} = {sum}");
}