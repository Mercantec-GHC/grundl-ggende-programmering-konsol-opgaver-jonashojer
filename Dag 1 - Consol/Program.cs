Console.WriteLine("Hello, World!");

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");
Console.Write('\n');

Console.Write('h');
Console.Write('e');
Console.Write('l');
Console.Write('l');
Console.Write('o');
Console.Write('\n');

Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);

Console.WriteLine(true);
Console.WriteLine(false);

string firstName = "Jonas";

char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;

Console.WriteLine(firstName);

firstName = "Alex";

Console.WriteLine(firstName);

firstName = "Mikkel";

Console.WriteLine(firstName);

var message = "Hello from variable";

Console.WriteLine(message);

string helloBob;
int numberOfMessages = 3;
decimal temperature = 34.4M;

helloBob = "Hello, Bob! You have " + numberOfMessages + " in your inbox. The temperatur is " + temperature + " celcius.";

Console.WriteLine(helloBob);

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices");

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

string greeting = "Hello";

string message2 = $"{greeting} {firstName}!";

Console.WriteLine(message2);


int version = 11;
string updateText = "Update to Windows";
string message3 = $"{updateText} {version}";
Console.WriteLine(message3);




string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string project2Name = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"{project2Name} {russianMessage}");

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");


int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal quotient2 = (decimal)first / (decimal)second;
Console.WriteLine(quotient2);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);


int value = 0;
Console.WriteLine("Value is " + value);
value = value + 5;
Console.WriteLine("Value is now " + value);
value += 5;
Console.WriteLine("Value is now " + value);


value = 0;
Console.WriteLine("Value is " + value);
value = value + 1;
Console.WriteLine("Value is now " + value);
value++;
Console.WriteLine("Value is now " + value);
value = value - 1;
Console.WriteLine("Value is now " + value);
value -= value;
Console.WriteLine("Value is now " + value);

Console.WriteLine("Fourth: " + (++value));



int fahrenheit = 94;

int celciusSubtract = 32;

decimal temperatureOutside = (fahrenheit - celciusSubtract) * 5m / 9m;

Console.WriteLine(temperatureOutside);

int result = 3 + 1 * 5 / 2;

Console.WriteLine(result);

Console.WriteLine(5 / 10);