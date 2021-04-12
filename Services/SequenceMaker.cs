using System;
using System.Collections.Generic;
using Sequence.Interfaces;

namespace Sequence.Services
{
	public class SequenceMaker : ISequenceMaker
	{
		public List<int> MadeIntegers { get; set; }
		public double Limit { get; set; }

		public SequenceMaker(double n)
		{
			MadeIntegers = new List<int>();
			Limit = Math.Sqrt(n);

			for (double i = 1; i < Limit; i++)
			{
				MadeIntegers.Add(Convert.ToInt32(i));
			}
		}
	}
}
