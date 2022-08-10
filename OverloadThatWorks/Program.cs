using System;

namespace OverloadThatWorks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine(10);

			int sum1 = Add(5, 3);
			Console.WriteLine(sum1);
			double sum2 = Add(5.5, 3.5);

		}

		// This is called overloading
		static int Add(int x, int y)
		{
			return x + y;
		}

		static double Add(double x, double y)
		{
			return x + y;
		}
	}
}
