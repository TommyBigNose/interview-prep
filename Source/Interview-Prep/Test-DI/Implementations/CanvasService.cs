using System.Collections.Generic;
using System.Text;
using Test_DI.Interfaces;

namespace Test_DI.Implementations
{
	public class CanvasService : ICanvasService
	{
		private List<IShapeService> _shapes;

		public CanvasService()
		{
			IShapeService circle = new CircleShapeService();
			IShapeService square = new SquareShapeService();

			_shapes = new List<IShapeService>()
			{
				circle,
				square
			};
		}
		public string DrawAllShapes()
		{
			StringBuilder result = new StringBuilder(100);
			foreach (IShapeService shape in _shapes)
			{
				result.AppendLine($"Shape: {shape.Draw()}");
			}
			return result.ToString();
		}
	}
}
