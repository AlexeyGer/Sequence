using System;
using Sequence.Interfaces;

namespace Sequence.View
{
	public class SequenceViewer
	{
		public SequenceViewer(ISequence sequence)
		{
			foreach (int integer in sequence)
			{
				Console.Write(integer + ", ");
			}
		}
	}
}
