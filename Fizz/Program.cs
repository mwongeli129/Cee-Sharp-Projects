using System;

class Progam
{

	static void main()
	{
		Console.WriteLine(" Enter the start of the range: ");
		int start = int.Parse(Console.ReadLine());
		Console.WriteLine(" Enter the end of the range: ");
		int end = int.Parse(Console.ReadLine());

		for (int i = start; i <= end; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
			{
				Console.WriteLine("FizzBuzz");
			}
			else if (i % 3 == 0)
			{
				Console.WriteLine(" Fizz");
			}
			else if (i % 5 == 0)
			{
				Console.WriteLine(" Buzz");
			}
			else
			{
				Console.WriteLine(i);
			}



		}

	}

}
