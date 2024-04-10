Random rand = new Random();

//int current = 0;
//int hero = 10;
//int monster = 10;


/*
do {
    current = rand.Next(1, 11);
    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);

while (current >= 3) {
    Console.WriteLine(current);
    current = rand.Next(1,11);
};
Console.WriteLine($"Last Number: {current}");

// Simple Fight sim
int heroLife = 10;
int monLife = 10;

do {
    int dmg = rand.Next(1,11);
    heroLife -= dmg;
    Console.WriteLine($"Hero was damaged and lost {dmg} and now has {heroLife}");
    if (monLife < 1) break;
    dmg = rand.Next(1,11);
    monLife -= dmg;
    Console.WriteLine($"Monster was damaged and lost {dmg} and now has {monLife}");
} while (( heroLife > 0 ) || (monLife > 0));

if (monLife < 1) {
    Console.WriteLine("Hero wins!");
} else {
    Console.WriteLine("Monster wins!");
};


//Validate integer input

int num = 0;
Console.WriteLine("Enter any number between 5 and 10");

do {
    string userInput = Console.ReadLine();
    int.TryParse(userInput, out num);
    Console.WriteLine("Try again");
} while ((num < 4)||(num > 11));



string? userInput;
int numInput;
// validating number
do {
    Console.WriteLine("Give a number between");
    userInput = Console.ReadLine();
} while (!int.TryParse(userInput, out numInput));


} while (!int.TryParse(userInput, out numInput));
*/


string? userInput;
int numInput = 0;
bool end = false;

Console.WriteLine("Please, enter a number between 5 and 10");

do {
    userInput = Console.ReadLine();
    
    if ((numInput > 4)&&(numInput < 11)) {
        Console.WriteLine($"Number {numInput} is valid.");
        end = true;
    } else {
        if (int.TryParse(userInput, out numInput)) {
            Console.WriteLine($"You entered {numInput}, please enter a number between 5 and 10");
            userInput = Console.ReadLine();
        } else {end = true;}
    } while (!end);
    if (pass) end = true;
} while (!end);
Console.WriteLine($"Your input {numInput} has been accepted.");
