using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.src.OopPrinciples.Encapsulation
{
	public class BankAccount
	{
		//private field
		private decimal balance;

		//constructor
		public BankAccount(decimal balance) {
			//method
			Deposit(balance);
		}

		public decimal GetBalance() {
			return balance;
		}

		public void Deposit(decimal amount) {
			if(amount <= 0) {
				throw new ArgumentException("Deposit amount must be positive");
			}

			this.balance += amount;
		}
		
		public void Withdraw(decimal amount) {
		if(amount <= 0) {
			throw new ArgumentException("Withdrawal amount must be positive");
		}

		if(amount > balance) {
			throw new InvalidOperationException("Insufficient funds");
		}

		this.balance -= amount;
		}
	};
};