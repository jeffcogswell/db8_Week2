// Let's make an array for comparison
string[] myarray = { "abc", "def", "ghi" };

// Let's print out one element
Console.WriteLine(myarray[0]);

// Let's change one of the elements
myarray[1] = "jkl";

// Let's loop through it
for (int ind = 0; ind < myarray.Length; ind++)
{
	Console.WriteLine(myarray[ind]);
}

Console.WriteLine();

//
// Now let's use a List
//

List<string> mylist = new List<string>();
mylist.Add("Abc");
mylist.Add("Def");
mylist.Add("Ghi");

// Let's print out one element
Console.WriteLine(mylist[0]);

// Let's chane one of the elements
mylist[1] = "Jkl";

// Let's add another one!
mylist.Add("Mno");

for (int ind = 0; ind < mylist.Count; ind++)
{
	Console.WriteLine(mylist[ind]);
}

// Delete one from the list
// Insert one into the list
// We'll look at the official documentation

Console.WriteLine("Let's remove the one at index 2");
mylist.RemoveAt(2);
for (int ind = 0; ind < mylist.Count; ind++)
{
	Console.WriteLine(mylist[ind]);
}

//mylist.Add("Abc");
//mylist.Add("Abc");

Console.WriteLine("Let's remove one by name: Abc");
mylist.Remove("Abc");
for (int ind = 0; ind < mylist.Count; ind++)
{
	Console.WriteLine(mylist[ind]);
}

//  xxx here yyy

Console.WriteLine("Now let's insert one in between the first two.");
mylist.Insert(1, "Pqr");
foreach (string nextletters in mylist)
{
	// We can't see the index
	Console.WriteLine(nextletters);
}

// Some functions modify the list. They actually do change the list itself, unlike string functions.
Console.WriteLine("Let's sort the list.");
mylist.Sort();
foreach (string nextletters in mylist)
{
	Console.WriteLine(nextletters);
}

// Let's check if one exists
Console.WriteLine("Type in a word and we'll see if it's in the list.");
string entry = Console.ReadLine();
int index = mylist.IndexOf(entry);
if (index >= 0)
{
	Console.WriteLine($"found {entry} at {index}.");
}
else
{
	// In this case we got back a -1, meaning it wasn't found
	Console.WriteLine($"Sorry, {entry} is not in the list.");
}


// Let's initialize a list
Console.WriteLine("Let's initialize a list of integers.");
List<int> numbers = new List<int>() { 5, 3, 8, 2 };
foreach (int nextnum in numbers)
{
	Console.WriteLine($"The next number is {nextnum}");
}
