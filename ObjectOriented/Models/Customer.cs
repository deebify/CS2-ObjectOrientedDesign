using System;

namespace ObjectOriented
{
	public class Customer
	{
		public String firstName {
			get;
			set;
		}

		public String lastName {
			get;
			set;
		}

		public int SSN {
			get;
			set;
		}

		public int customerID {
			get;
			set;
		}

		public BankAccount customerAccount {
			get;
			set;
		}
			

	
		public override string ToString ()
		{
			return "\n\n"+string.Format ("[Customer: firstName={0}, lastName={1}, SSN={2}, customerID={3}, customerAccount={4}]", firstName, lastName, SSN, customerID, customerAccount);
		}
	
	}
}

