using System;

class GlazerCalc
{
	static void Main()
	{
		double width, height, woodLength, glassArea;
		string widthString, heightString;

		Console.WriteLine("Enter the width of the window:");
		Console.WriteLine("Blah");
		widthString = Console.ReadLine();
		width = double.Parse(widthString);

		Console.WriteLine("Enter the height of the window:");
		heightString = Console.ReadLine();
		height = double.Parse(heightString);

		woodLength = 2 * (width + height) * 3.25;
		glassArea = 2 * (width * height);

		Console.WriteLine("The length of the wood is " + woodLength + " feet");
		Console.WriteLine("The area of the glass is " + glassArea + " square meters");
	}
}