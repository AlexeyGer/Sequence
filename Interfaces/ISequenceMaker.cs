using System.Collections.Generic;

namespace Sequence.Interfaces
{
	public interface ISequenceMaker
	{
		List<int> MadeIntegers { get; set; }
		double Limit { get; set; }
	}
}
