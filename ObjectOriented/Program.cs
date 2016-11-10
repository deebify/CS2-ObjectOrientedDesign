using System;
using static System.Console;
using AccessModifiers;

namespace ObjectOriented
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Customer a = new Customer ();
			a.customerID = 1;
			a.firstName = "Yassine";
			a.lastName = "Abdul-Rahman";
			a.SSN = 122121;
			BankAccount account = new BankAccount ();
		

			try {
				account.balance = 200;

				account.type = "Debit";
				account.deposite (33);


			} catch (Exception ex) {
				WriteLine(ex.ToString ());
			}


			a.customerAccount = account;
			WriteLine (account);

			WriteLine ("... Abstraction ... ");

			WriteLine ("");
			Accountant accountant = new Accountant ();
			accountant.AccountID = 23;


			WriteLine (accountant);

		
		
		}
	}
}
