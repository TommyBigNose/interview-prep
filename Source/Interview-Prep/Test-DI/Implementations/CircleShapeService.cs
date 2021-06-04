using Test_DI.Interfaces;

namespace Test_DI.Implementations
{
	public class CircleShapeService : IShapeService
	{
		public string Draw()
		{
			return "()";
		}
	}
}
