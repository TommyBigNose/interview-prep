using Test_Factory.Interfaces;

namespace Test_Factory.Implementations
{
	public class MoneyBackCreditCard : ICreditCard
	{
		public string GetCardType()
		{
			return Constants.CreditCardNames.MoneyBack;
		}
		public int GetCreditLimit()
		{
			return 15000;
		}
		public int GetAnnualCharge()
		{
			return 500;
		}
	}
}
