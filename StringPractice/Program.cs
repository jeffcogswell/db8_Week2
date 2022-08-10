
string sentence = "Hello there everybody from planet earth!";

string[] words = sentence.Split(); // noun dot verb, the noun is a variable, in this case sentence (string).

foreach (string word in words)
{
	Console.WriteLine(word);
}

Console.WriteLine();
Console.WriteLine("Split by commas:");
sentence = "Hello,there,everybody,from,planet earth!";

char[] delims = {     ','     ,     ' '    }; // Split by comma or space
words = sentence.Split(delims);
foreach (string word in words)
{
	Console.WriteLine(word);
}

// Let's join these words back together

sentence = string.Join(';', words);
Console.WriteLine(sentence);

// Now let's try joining with spaces!

sentence = string.Join(' ', words); // noun dot verb, the noun is a type, in this case string. (Similar to int.Parse)
                                    // Methods that are attached to the type itself are called "static" methods.
									// Methods that are attached to an instance of the type (such as sentence) are called
									//     instance methods.
Console.WriteLine(sentence);

// Let's find the position of a letter in a string.
// IndexOf uses a common approach: It returns a 0-based index, or -1 if it doesn't find it.

Console.WriteLine();
Console.WriteLine("IndexOf Practice");
sentence = "We will find a letter position.";
Console.WriteLine(sentence.IndexOf('i'));
Console.WriteLine(sentence.IndexOf('x'));
Console.WriteLine(sentence.LastIndexOf('i'));
Console.WriteLine(sentence.LastIndexOf('x'));

// Let's use Substring to find a piece of a string
Console.WriteLine();
Console.WriteLine("Substring practice");
sentence = "Hello World";
Console.WriteLine(sentence.Substring(1));    // Expect "ello World"
Console.WriteLine(sentence.Substring(3));    // Expect "lo World"
Console.WriteLine(sentence.Substring(4,3));  // Expect "o W"
