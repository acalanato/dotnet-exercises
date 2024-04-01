// See https://aka.ms/new-console-template for more information
int firstNumber = 12;
int secondNumber = 7;

Console.WriteLine("Both sum equals to" + firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

int fahrenheit = 94;
decimal celsius = (fahrenheit -32m) * (5m/9m);
Console.WriteLine($"The temperature is {celsius} Celsius.");
