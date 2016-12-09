using System;

namespace TestProject
{
	public class Windows : PC , CISC
	{
		public Windows ()
		{
			Console.WriteLine ("Windows is Starting ..");
		}

		public void multiThreadProcess(){
			Console.WriteLine ("MultiThread CISC on Windows");
		}

	}
}

