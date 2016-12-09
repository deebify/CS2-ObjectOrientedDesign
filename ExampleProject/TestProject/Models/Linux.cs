using System;

namespace TestProject
{
	public class Linux : ARM, CISC, RISC
	{
		public Linux ()
		{
			Console.WriteLine ("Setting Up Linux");
		}
			

		public void threadOneProcess(){
			Console.WriteLine ("Processes 1 ARM on Linux");
		}

		public void multiThreadProcess(){
			Console.WriteLine ("MultiThread CISC on Linux");
		}

		public void parallelThreadProcess(){
			Console.WriteLine ("Parallel RISC on Linux");
		}
	}
}

