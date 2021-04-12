using System;
using Sequence.Sources;
using Sequence.Controllers; 

namespace Sequence
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				new SequenceController(args);
			}
			catch (Exception e)
			{
				Message.Instruction();
				//Console.WriteLine("\n" + e);
			}
			Console.ReadKey();
		}
	}
}
