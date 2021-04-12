using System;

namespace Sequence.Services
{
	public class Parser
	{
		public double InputLimiter;

		public Parser(string[] inputArgs)
		{
			double parsedArg = -1;

			if (Validator.FormatValidation(inputArgs, out string validArg))
			{
				parsedArg = Double.Parse(validArg);
			}

			if (Validator.PositiveValidation(parsedArg, out double validPositiveArgs))
			{
				InputLimiter = validPositiveArgs;
			}
		}
	}
}
