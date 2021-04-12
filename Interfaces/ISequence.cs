using System.Collections.Generic;

namespace Sequence.Interfaces
{
	public interface ISequence
	{
		List<int> Integers { get; set; }
		IEnumerator<int> GetEnumerator();
	}
}
