using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceTest
{
	public class PointClass
	{
		public int X;
		public int Y;
		public static float PointDistanceFloat(PointClass pointOne, PointClass pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}
	}
}
