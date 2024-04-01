Random random = new Random();
int daysUntilExpiration = random.Next(12);
//int daysUntilExpiration = 12;
//int discountPercentage = 0;

// Your code goes here
string msg1 = "Your subscription will expire soon. Renew now!";
string msg3 = "Your subscription expires within a day!\nRenew now and save 20%!";
string msg4 = "Your subscription has expired.";
if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5)){
    Console.WriteLine(msg1);
}
if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1)){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
}
if (daysUntilExpiration == 1){
    Console.WriteLine(msg3);
}
if (daysUntilExpiration == 0){
    Console.WriteLine(msg4);
}
