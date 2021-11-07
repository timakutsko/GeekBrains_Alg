using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DistanceTest
{
	public struct PointStruct
	{
		public int X;
		public int Y;
		
		[StructLayout(LayoutKind.Explicit, Pack = 1)]
		public struct FloatIntUnion
		{
			[FieldOffset(0)]
			public int i;

			[FieldOffset(0)]
			public float f;
		}
		
		public static float PointDistanceFloat(PointStruct pointOne, PointStruct pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}
		public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
		{
			double x = pointOne.X - pointTwo.X;
			double y = pointOne.Y - pointTwo.Y;
			return Math.Sqrt((x * x) + (y * y));
		}

		public static float PointDistanceNoSqrt(PointStruct pointOne, PointStruct pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return Fsrt((x * x) + (y * y));
		}
		
		private static float Fsrt(float z)
		{
			if (z == 0) return 0;
			FloatIntUnion u;
			u.i = 0;
			u.f = z;
			u.i -= 1 << 23; /* Subtract 2^m. */
			u.i >>= 1; /* Divide by 2. */
			u.i += 1 << 29; /* Add ((b + 1) / 2) * 2^m. */
			return u.f;
		}
	}
}
