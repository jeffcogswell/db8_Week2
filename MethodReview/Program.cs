while (true)
{
	Console.WriteLine();
	Console.WriteLine("Please enter an integer.");
	string entry = Console.ReadLine();

	int num;

	bool result = int.TryParse(entry, out num);
	if (result)
	{
		Console.WriteLine($"Great! Your number is {num}");
	}
	else
	{
		Console.WriteLine($"Sorry, {entry} is not a integer.");
	}
}




//double res = Divide(10, 2);
