using Sequence.Interfaces;
using Sequence.Services;
using Sequence.View;


namespace Sequence.Controllers
{
	public class SequenceController
	{
		public SequenceController(string[] inputArgs)
		{
			Parser parser = new Parser(inputArgs);
			ISequenceMaker maker = new SequenceMaker(parser.InputLimiter);
			ISequence sequence = new Models.Sequence { Integers = maker.MadeIntegers };
			new SequenceViewer(sequence);
		}
	}
}
