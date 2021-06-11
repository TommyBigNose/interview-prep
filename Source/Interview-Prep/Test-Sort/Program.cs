using System;
using System.Collections.Generic;

namespace Test_Sort
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, welcome to the sort test!");
			Console.WriteLine("------------------------------------------------------------------");

			List<string> namesList = new List<string>()
			{
				"Thomas",
				"Anna",
				"Dan",
				"Lisa",
				"Yuna",
				"Jeffery",
			};

			Console.WriteLine($"Unsorted Names \r\n{string.Join("\r\n", namesList)}");
			Console.WriteLine("------------------------------------------------------------------");

			// Sort the names of namesList in ascending order into sortedNamesList
			IEnumerable<string> sortedNamesList = new List<string>();
			Console.WriteLine($"Sorted Names Ascending \r\n{string.Join("\r\n", sortedNamesList)}");
			Console.WriteLine("------------------------------------------------------------------");

			// Sort the names of namesList in decending order into descOrder
			IEnumerable<string> descOrder = new List<string>();
			Console.WriteLine($"Sorted Names Descending \r\n{string.Join("\r\n", descOrder)}");
			Console.WriteLine("------------------------------------------------------------------");

			// Sort the names of namesList by length ascending into lengthOrder
			IEnumerable<string> lengthOrder = new List<string>();
			Console.WriteLine($"Sorted Names Length \r\n{string.Join("\r\n", lengthOrder)}");
			Console.WriteLine("------------------------------------------------------------------");

			Dictionary<string, int> playerPointsDictionary = new Dictionary<string, int>()
			{
				{"Thomas", 3},
				{"Anna", 2},
				{"Dan", 1},
				{"Lisa", 3},
				{"Yuna", 4},
				{"Jeffery", 0},
			};

			// Sort the pairs of playerPointsDictionary by name in ascending order into sortedPlayers
			var sortedPlayers = new Dictionary<string, int>();
			Console.WriteLine($"Player Points | Sorted Names Ascending \r\n{string.Join("\r\n", sortedPlayers)}");
			Console.WriteLine("------------------------------------------------------------------");

			// Sort the pairs of playerPointsDictionary by points (#) in ascending order into sortedPointsPlayers
			var sortedPointsPlayers = new Dictionary<string, int>();
			Console.WriteLine($"Player Points | Sorted Points Ascending \r\n{string.Join("\r\n", sortedPointsPlayers)}");
			Console.WriteLine("------------------------------------------------------------------");

			List<Player> players = new List<Player>()
			{
				new Player()
				{
					Name = "Thomas",
					Points = 3,
					DateStarted = new DateTime(2000, 1, 1)
				},
				new Player()
				{
					Name = "Anna",
					Points = 3,
					DateStarted = new DateTime(2003, 1, 1)
				},
				new Player()
				{
					Name = "Dan",
					Points = 1,
					DateStarted = new DateTime(2005, 1, 1)
				},
				new Player()
				{
					Name = "Lisa",
					Points = 3,
					DateStarted = new DateTime(2001, 1, 1)
				},
				new Player()
				{
					Name = "Yuna",
					Points = 4,
					DateStarted = new DateTime(1999, 1, 1)
				},
				new Player()
				{
					Name = "Jeffery",
					Points = 0,
					DateStarted = new DateTime(2021, 1, 1)
				}
			};

			// Update Players class to sort by both points ascending and date started ascending.
			// Update Players class with an override of the ToString function to cleanly output all their information
			players.Sort();
			Console.WriteLine($"Players | Sorted Points, DateStarted Ascending \r\n{string.Join("\r\n", players)}");
			Console.WriteLine("------------------------------------------------------------------");

			Console.WriteLine("Press enter to exit program.");
			Console.ReadLine();
		}
	}
}
