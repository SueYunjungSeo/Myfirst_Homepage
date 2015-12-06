/*

Instructions
------------
Write a LINQ query that results in all fruits that are a single word (i.e. exclude fruits like "Goji berries", as well as empty entries).
Sort the results by the length of the word, with the longest word first and the shortest word last.
The results should be lowercased.

*/

using System;
using System.Linq;

public class Program
{
	static readonly string[] Fruits = new []
	{
		"Acai",
		"Apple",
		"Apricots",
		"Banana",
		"Blackberry",
		"",
		"Blueberry",
		"Cherries",
		"Coconut",
		"Cranberry ",
		"Cucumber",
		"Currents",
		"Dates",
		"Durian",
		"Fig",
		"Goji berries",
		"Gooseberry",
		"Grapefruit",
		"Grapes",
		"Jackfruit",
		"Kiwi",
		"Kumquat",
		"Lemon",
		"Lime",
		"Lucuma",
		" Lychee",
		"Mango",
		"Mangosteen",
		"Melon",
		"",
		"Mulberry",
		"Nectarine",
		"Orange",
		"Papaya",
		"Passion Fruit",
		"Peach",
		"Pear",
		"Pineapple ",
		"Plum",
		"Pomegranate",
		"Pomelo",
		"Prickly Pear",
		"Prunes",
		"Raspberries",
		"Strawberries",
		"Tangerine",
		"Watermelon"
	};

	public void Main()
	{
		// Do your work here...

		var fruitQuery = from item in Fruits where !item.Contains(' ') && !item.Contains('\0') orderby item.Length descending select item.ToLower();

		//foreach (var item in fruitQuery)
		//	Console.WriteLine(item);

		Console.WriteLine("Answer: {0}", String.Join(", ", fruitQuery));

	}
}
