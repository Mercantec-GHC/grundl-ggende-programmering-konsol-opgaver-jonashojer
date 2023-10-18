﻿//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");

//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

//Console.WriteLine(pangram.Contains("fox") == false);
//Console.WriteLine(!pangram.Contains("fox"));

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(!pangram.Contains("fox"));
//Console.WriteLine(!pangram.Contains("cow"));

//int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

//int saleAmount = 1001;

//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//Random random = new Random();
//int coin = random.Next(1, 21);
//string result = coin > 10 ? "Heads" : "Tails";
//Console.WriteLine(result);

//string permission = "Admin|Manager";
//int level = 56;

//if (permission.Contains("Admin"))
//{
//	if (level > 55)
//	{
//		Console.WriteLine("Welcome, Super Admin user.");
//	}
//	else
//	{
//		Console.WriteLine("Welcome, Admin user.");
//	}
//}
//else if (permission.Contains("Manager"))
//{
//	if (level >= 20)
//	{
//		Console.WriteLine("Contact an Admin for access.");
//	}
//	else
//	{
//		Console.WriteLine("You do not have sufficient privileges.");
//	}
//}
//else
//{
//	Console.WriteLine("You do not have sufficient privileges.");
//}

//bool flag = true;
//int value = 0;
//if (flag)
//{
//	value = 10;
//	Console.WriteLine($"Inside of code block: {value}");
//}
//Console.WriteLine($"Outside of code block: {value}");


//string name = "steve";
//if (name == "bob") Console.WriteLine("Found Bob");
//else if (name == "steve") Console.WriteLine("Found Steve");
//else Console.WriteLine("Found Chuck");
//string name = "steve";

//if (name == "bob")
//	Console.WriteLine("Found Bob");
//else if (name == "steve")
//	Console.WriteLine("Found Steve");
//else
//	Console.WriteLine("Found Chuck");

//int[] numbers = { 4, 8, 15, 16, 23, 42 };

//bool found = false;
//int total = 0;


//foreach (int number in numbers)
//{

//	total += number;

//	if (number == 42)
//	{
//		found = true;
//	}

//}

//if (found)
//{
//	Console.WriteLine("Set contains 42");

//}

//Console.WriteLine($"Total: {total}");

//int employeeLevel = 100;
//string employeeName = "John Smith";

//string title = "";

//switch (employeeLevel)
//{
//	case 100:
//	case 200:
//		title = "Senior Associate";
//		break;
//	case 300:
//		title = "Manager";
//		break;
//	case 400:
//		title = "Senior Manager";
//		break;
//	default:
//		title = "Associate";
//		break;
//}

//Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0]) {
	case "01" :
		type = "Sweat shirt";
		break;

	case "02":
		type = "T-Shirt";
		break;

	case "03":
		type = "Sweat pants";
		break;

	default:
		type = "Other";
		break;
}

switch (product[1]) {
	case "BL":
		color = "Black";
		break;

	case "MN":
		color = "Maroon";
		break;

	default:
		color = "White";
		break;
}

switch (product[2]) {
	case "S":
		size = "Small";
		break;

	case "M":
		size = "Medium";
		break;

	case "L":
		size = "Large";
		break;

	default:
		size = "One Size Fits All";
		break;
}

Console.WriteLine($"Product: {size} {color} {type}");