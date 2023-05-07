Console.WriteLine("Enter number A:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number B:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("What would you like to do with those number?");
char action = char.Parse(Console.ReadLine());
if (action == '+')
{ 
    double result = a + b;
    Console.WriteLine(result);
}
else if (action == '-')
{ 
    double result = a - b;
    Console.WriteLine(result);
}
else if (action == '*')
{
    double result = a * b;
    Console.WriteLine(result);
}
else if (action == '/')
{
    double result = a / b;
    Console.WriteLine(result);
}
else if (action == '%')
{
    double result = a % b;
    Console.WriteLine(result);
}
