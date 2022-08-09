int x = 10;
double y = 2.5;

var z = 2.5;
var a = 6;
var b = "Hello";

var c = z + a; // We don't automatically know what this is, unless we see the rest of the code.

double d = z + a;

Dictionary<string, int> nums = new Dictionary<string, int>();
nums["One"] = 1;
nums["Ten"] = 10;
nums["Twenty"] = 20;

foreach (KeyValuePair<string, int> pair in nums)
{
	Console.WriteLine($"{pair.Key} -> {pair.Value}");
}

