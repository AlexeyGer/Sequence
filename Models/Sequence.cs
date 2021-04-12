using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sequence.Interfaces;

namespace Sequence.Models
{
	public class Sequence : ISequence
	{
		public List<int> Integers { get; set; }

		public IEnumerator<int> GetEnumerator()
		{
			for (int i = 0; i < Integers.Count; i++)
			{
				yield return Integers[i];
			}
		}
	}
}
