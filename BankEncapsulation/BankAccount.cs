using System;
namespace BankEncapsulation
{
	internal class BankAccount
	{
		private double _balance = 0.0;

		public void Deposit(double money)
		{
			_balance += money;
		}

		public double GetBalance()
		{
            Console.WriteLine($"{_balance}");
			return _balance;
			
		}
	}
}

