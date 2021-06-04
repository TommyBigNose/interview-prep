using System;
using Test_Factory.Implementations;
using Test_Factory.Interfaces;

namespace Test_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, please let me know which credit card you would like to preview.");
			Console.WriteLine($"{Constants.CreditCardNames.MoneyBack}, {Constants.CreditCardNames.Titanium}, or {Constants.CreditCardNames.Platinum}");

			string input = Console.ReadLine();

			// How would you use the Factory Pattern at this point?
			ICreditCard creditCard = new MoneyBackCreditCard();
			Console.WriteLine($"Card Type: {creditCard.GetCardType()}");
			Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit()}");
			Console.WriteLine($"Annual Charge: {creditCard.GetAnnualCharge()}");

			Console.WriteLine("Press enter to exit program.");
			Console.ReadLine();
		}
	}
}
