using System;
using Test_DI.Implementations;
using Test_DI.Interfaces;

namespace Test_DI
{
	class Program
	{
		static void Main(string[] args)
		{
			// If I wanted my shapes to be from my SQL Database, how would I change this code?
			ICanvasService canvasService = new CanvasService();

			Console.WriteLine($"{canvasService.DrawAllShapes()}");

			Console.WriteLine("Press enter to exit program.");
			Console.ReadLine();
		}
	}
}
