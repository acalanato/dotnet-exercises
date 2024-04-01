// See https://aka.ms/new-console-template for more information
var msg = "Hello Fucker!";
Console.WriteLine(msg);

Console.WriteLine(34.40M);

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Literal de cadeia de caracteres verbatim

Console.WriteLine(@"
c:\source\repos
(this is where your code goes)
Não acredito que é só colocar uma arroba");


// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

/*
Veja o que você aprendeu sobre a formatação de cadeias de caracteres literais até agora:

Use as sequências de escape de caractere quando precisar inserir um caractere especial em uma cadeia de caracteres literal, como uma tabulação \t, uma nova linha \n ou uma aspa dupla \".
Use um caractere de escape para a barra invertida \\ quando precisar usar uma barra invertida em todos os outros cenários.
Use a diretiva @ para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco e caracteres de barra invertida em uma cadeia de caracteres.
Use o \u mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres.
Os caracteres Unicode podem não ser impressos corretamente dependendo do aplicativo.
*/

Console.WriteLine($"{msg} ... again");

// combined verbatim and interpolation
//string projectName = "First-Project";
//Console.WriteLine($@"C:\Output\{projectName}\Data");

// last one
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"
View English output:
  c:\Exercise\{projectName}\data.txt

{russianMessage}
  c:\Exercise\ACME\ru-RU\data.txt
");
