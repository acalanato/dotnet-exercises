/*
string[] orderID = new string[3];
orderID[0] = "A123";
orderID[1] = "B456";
orderID[2] = "C789";
orderID[3] = "0000";


string[] orderID = { "A123", "B456", "C789" };


Console.WriteLine($"{orderID[0]}, {orderID[1]}, {orderID[2]}");

Console.WriteLine($"There are {orderID.Length} fraudulent orders to process.");


string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names) {
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach (int items in inventory){
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running Total: {sum})");
}
    
Console.WriteLine($"We have {sum} items in the inventory.");
*/

string[] arr = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string i in arr){
    if (i.StartsWith("B")){
        Console.WriteLine($"{i}");
    }
    
}
Console.WriteLine($"{arr[2]}");
