// convert the message into a char array
string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();

// Reverse the chars
Array.Reverse(charMessage);

// count the o's
int x = 0;
foreach (char i in charMessage) { if (i == 'o') { x++; } }

// convert it back to a string
string new_message = new String(charMessage);

// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");