using System;

namespace TestProject
{
	public class PC
	{
		public String getVer {
			get;
			set;
		}

		public String getName {
			get;
			set;
		}
			
		public PC ()
		{
			Console.WriteLine ("PC Constructor");
		}

		public void setRAMSize(int size){
			Console.WriteLine ("Setting Ram to : ",size);
		}
	}
}

