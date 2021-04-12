using System;

namespace Sequence.Services
{
	public static class Validator
	{
        // Validate first input arg. Can be changed to validate all args.
        public static bool FormatValidation(string[] inputArgs, out string validArg)
        {
            validArg = null;

            if (inputArgs.Length == 1 && Double.TryParse(inputArgs[0], out _))
            {
                validArg = inputArgs[0];
                return true;
            }
            else
            {
                throw new Exception();
            }
        }

        public static bool PositiveValidation(double parsedArg, out double validPositiveArg)
        {
            validPositiveArg = -1;

            if (parsedArg > 1)
            {
               validPositiveArg = parsedArg;
               return true;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
