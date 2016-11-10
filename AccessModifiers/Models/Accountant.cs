using System;

namespace AccessModifiers
{
	public class Accountant
	{

		public int AccountID {
			get;
			set;
		}


		public override string ToString ()
		{
			return string.Format ("[Accountant: AccountID={0}]", AccountID);
		}
	}
}

