// A dictionary of favorite numbers.
// The key is the name of the person, so it's a string.
// The value is that person's list of favorite numbers. So it's a list of int.

Dictionary<string, List<int>> Favorites = new Dictionary<string, List<int>>();

Favorites["Paul"] = new List<int>() { 10, 100, 1000, 10000 };
Favorites["Sarah"] = new List<int>() { 2, 4, 6, 8, 10, 12, 14 };
Favorites["Quincy"] = new List<int>() { 1, 3, 5, 7};
Favorites["Ruby"] = new List<int>() { 16, 38, 284, 8537, 17 };
Favorites["Terry"] = new List<int>() { 2, 2, 2, 2, 2 };

foreach (var pair in Favorites)
{
	Console.WriteLine(pair.Key);
	foreach (int num in pair.Value)
	{
		Console.WriteLine(num);
	}
}
