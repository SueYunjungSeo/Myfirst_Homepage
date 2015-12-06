/*

Instructions
------------
Reverse the string and output the result.
For the purposes of this exercise, please avoid using Array.Reverse().

*/

using System;

public class Program
{
	public void Main()
	{
		string str = "Reverse me!!";

		// Do your work here...

		string anr = "";

		for(int i=0; i<str.Length; i++)
		{
			anr += str.Substring(str.Length - 1 -i,1);
		}

		Console.WriteLine("Answer: {0}", anr);
	}
}
