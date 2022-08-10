//
// This example demonstrates two data structures: Stacks and Queues
//    (Different "stack" from the concept of stacks and heaps!)

Console.WriteLine("Let's do some stack practice!");

Stack<string> cards = new Stack<string>();

cards.Push("3D");
cards.Push("AS");
cards.Push("QH");
cards.Push("10D");

string next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

//next = cards.Pop();   If we pop again, we'll get a "stack empty" exception


Console.WriteLine();
Console.WriteLine("Now let's do some Queue practice.");

Queue<int> nums = new Queue<int>();
nums.Enqueue(5);  // 5 got there first
nums.Enqueue(10);
nums.Enqueue(15);
nums.Enqueue(20);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

// Console.WriteLine(nums.Dequeue()); This line will throw an exception

Console.WriteLine();
Console.WriteLine("Advanced stack stuff");

cards.Clear();    // This empties out the stack. It clears it

cards.Push("5D");
cards.Push("JH");
cards.Push("3S"); // So far we have 5D on the bottom, JH next on top, and 3S at the very top

Console.WriteLine(cards.Pop());  // Expect 3S

// Let's just look at the top of the deck but not pull it off
string top = cards.Peek();
Console.WriteLine($"The top is {top} but we didn't remove it.");

// We didn't remove JH, so it's still there. So the next pop will be JH.

Console.WriteLine(cards.Pop());   // Expect JH

cards.Push("9H");
cards.Push("10D");
cards.Push("KS");

Console.WriteLine(cards.Pop());   // Expect KS

cards.Push("5D");

// Now let's draw them all off

Console.WriteLine("Let's draw all the rest of the cards!");
while (cards.Count > 0)
{
	next = cards.Pop();
	Console.WriteLine($"We just drew {next}.");
}

Console.WriteLine($"The count of the deck is now {cards.Count}"); // Expect to see 0
