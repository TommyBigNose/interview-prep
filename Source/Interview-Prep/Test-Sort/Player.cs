using System;

namespace Test_Sort
{
	public class Player : IComparable
	{
		public string Name { get; set; }
		public int Points { get; set; }
		public DateTime DateStarted { get; set; }

		public int CompareTo(object? obj)
		{
			if (obj == null) return 1;
			Player otherPlayer = obj as Player;

			int result = 0;

			return result;
		}
	}
}
