using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTumbleBit.CLI
{
	public class StopDetectException : Exception
	{
		public StopDetectException():base("")
		{

		}
		public StopDetectException(string message) : base(message)
		{

		}
	}
}
