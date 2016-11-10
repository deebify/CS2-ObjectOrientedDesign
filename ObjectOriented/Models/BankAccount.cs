using System;

namespace ObjectOriented
{
	public class BankAccount
	{
		//Encapsulate this field
		private double _balance;

		public double balance {
			get { 
				return _balance;
			}
			set {
				if (value < 0)
					throw new Exception ("CANNOT START WITH \"-\" Account");
				_balance = (value > 0.0) ? value : 0.0;
			}
		}

		public String type {
			get;
			set;
		} = "Checking Account";
			

		public void deposite(double amount){
			balance += amount > 0 ? amount : 0.0;

			if (amount < 0)
				throw new Exception ("CANNOT DEPOSITE \"-\" VALUE");
			
		}

		public void draw(double amount){
			balance -= amount > 0 ? amount : 0.0;

			if (amount < 0)
				throw new Exception ("CANNOT DRAW \"-\" VALUE");
		}

		public override string ToString ()
		{
			return "\n\n"+string.Format ("[BankAccount: balance={0}, type={1}]", balance, type);
		}
	}
}

