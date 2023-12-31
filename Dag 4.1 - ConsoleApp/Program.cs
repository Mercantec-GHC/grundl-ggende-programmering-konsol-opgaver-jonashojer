﻿////////////////////////////////////////////Console.WriteLine("Signed integral types:");

////////////////////////////////////////////Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
////////////////////////////////////////////Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
////////////////////////////////////////////Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
////////////////////////////////////////////Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

////////////////////////////////////////////Console.WriteLine("");
////////////////////////////////////////////Console.WriteLine("Unsigned integral types:");

////////////////////////////////////////////Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
////////////////////////////////////////////Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
////////////////////////////////////////////Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
////////////////////////////////////////////Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//////////////////////////////////////////Console.WriteLine("");
//////////////////////////////////////////Console.WriteLine("Floating point types:");
//////////////////////////////////////////Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
//////////////////////////////////////////Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
//////////////////////////////////////////Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

////////////////////////////////////////int[] data = new int[3];

//////////////////////////////////////int first = 2;
//////////////////////////////////////string second = "4";
//////////////////////////////////////string result = first + second;
//////////////////////////////////////Console.WriteLine(result);

////////////////////////////////////int myInt = 3;
////////////////////////////////////Console.WriteLine($"int: {myInt}");

////////////////////////////////////decimal myDecimal = myInt;
////////////////////////////////////Console.WriteLine($"decimal: {myDecimal}");

//////////////////////////////////decimal myDecimal = 3.14m;
//////////////////////////////////Console.WriteLine($"decimal: {myDecimal}");

//////////////////////////////////int myInt = (int)myDecimal;
//////////////////////////////////Console.WriteLine($"int: {myInt}");

////////////////////////////////decimal myDecimal = 1.23456789m;
////////////////////////////////float myFloat = (float)myDecimal;

////////////////////////////////Console.WriteLine($"Decimal: {myDecimal}");
////////////////////////////////Console.WriteLine($"Float  : {myFloat}");

//////////////////////////////int first = 5;
//////////////////////////////int second = 7;
//////////////////////////////string message = first.ToString() + second.ToString();
//////////////////////////////Console.WriteLine(message);

////////////////////////////string first = "5";
////////////////////////////string second = "7";
////////////////////////////int sum = int.Parse(first) + int.Parse(second);
////////////////////////////Console.WriteLine(sum);
//////////////////////////string value1 = "5";
//////////////////////////string value2 = "7";
//////////////////////////int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
//////////////////////////Console.WriteLine(result);

////////////////////////int value = (int)1.5m; // casting truncates
////////////////////////Console.WriteLine(value);

////////////////////////int value2 = Convert.ToInt32(1.5m); // converting rounds up
////////////////////////Console.WriteLine(value2);

//////////////////////string name = "Bob";
//////////////////////Console.WriteLine(int.Parse(name));

////////////////////string value = "102";
////////////////////int result = 0;
////////////////////if (int.TryParse(value, out result))
////////////////////{
////////////////////	Console.WriteLine($"Measurement: {result}");
////////////////////}
////////////////////else
////////////////////{
////////////////////	Console.WriteLine("Unable to report the measurement.");
////////////////////}

//////////////////string value = "bad";
//////////////////int result = 0;
//////////////////if (int.TryParse(value, out result))
//////////////////{
//////////////////	Console.WriteLine($"Measurement: {result}");
//////////////////}
//////////////////else
//////////////////{
//////////////////	Console.WriteLine("Unable to report the measurement.");
//////////////////}

//////////////////if (result > 0)
//////////////////	Console.WriteLine($"Measurement (w/ offset): {50 + result}");

////////////////string hest = "2.71828";
////////////////decimal.TryParse(hest, out decimal myHest);

//////////////string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//////////////decimal total = 0m;
//////////////string message = "";

//////////////foreach (var value in values)
//////////////{
//////////////	decimal number; // stores the TryParse "out" value
//////////////	if (decimal.TryParse(value, out number))
//////////////	{
//////////////		total += number;
//////////////	}
//////////////	else
//////////////	{
//////////////		message += value;
//////////////	}
//////////////}

//////////////Console.WriteLine($"Message: {message}");
//////////////Console.WriteLine($"Total: {total}");

////////////int value1 = 12;
////////////decimal value2 = 6.2m;
////////////float value3 = 4.3f;

////////////// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
////////////// Convert.ToInt32() rounds up the way you would expect.
////////////int result1 = Convert.ToInt32((decimal)value1 / value2);
////////////Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

////////////decimal result2 = value2 / (decimal)value3;
////////////Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

////////////float result3 = value3 / value1;
////////////Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

////////string[] pallets = { "B14", "A11", "B12", "A13" };

////////Console.WriteLine("Sorted...");
////////Array.Sort(pallets);
////////foreach (var pallet in pallets)
////////{
////////	Console.WriteLine($"-- {pallet}");
////////}

////////Console.WriteLine("");
////////Console.WriteLine("Reversed...");
////////Array.Reverse(pallets);
////////foreach (var pallet in pallets)
////////{
////////	Console.WriteLine($"-- {pallet}");
////////}

//////string[] pallets = { "B14", "A11", "B12", "A13" };
//////Console.WriteLine("");

//////Array.Clear(pallets, 0, 2);
//////Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
//////foreach (var pallet in pallets)
//////{
//////	Console.WriteLine($"-- {pallet}");
//////}

//////Console.WriteLine("");
//////Array.Resize(ref pallets, 6);
//////Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

//////pallets[4] = "C01";
//////pallets[5] = "C02";

//////foreach (var pallet in pallets)
//////{
//////	Console.WriteLine($"-- {pallet}");
//////}

//////Console.WriteLine("");
//////Array.Resize(ref pallets, 3);
//////Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

//////foreach (var pallet in pallets)
//////{
//////	Console.WriteLine($"-- {pallet}");
//////}

////string value = "abc123";
////char[] valueArray = value.ToCharArray();
////Array.Reverse(valueArray);
////// string result = new string(valueArray);
////string result = String.Join(",", valueArray);
////Console.WriteLine(result);

////string[] items = result.Split(',');
////foreach (string item in items)
////{
////	Console.WriteLine(item);
////}

//string pangram = "The quick brown fox jumps over the lazy dog";

//// Step 1
//string[] message = pangram.Split(' ');

////Step 2
//string[] newMessage = new string[message.Length];

//// Step 3
//for (int i = 0; i < message.Length; i++)
//{
//	char[] letters = message[i].ToCharArray();
//	Array.Reverse(letters);
//	newMessage[i] = new string(letters);
//}

////Step 4
//string result = String.Join(" ", newMessage);
//Console.WriteLine(result);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
	if (item.Length == 4)
	{
		Console.WriteLine(item);
	}
	else
	{
		Console.WriteLine(item + "\t- Error");
	}
}