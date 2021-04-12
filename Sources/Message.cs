using System;

namespace Sequence.Sources
{
	public static class Message
	{
		public static void Instruction()
		{
			Console.WriteLine($"To create new sequence of integers " +
				$"\nwhere each member squares will be less than limiter:" +
				$"\n\nPlease enter limiter as argument of command line." +
				$"\nThe limiter must be positive integer or float number.");
		}
	}
}
