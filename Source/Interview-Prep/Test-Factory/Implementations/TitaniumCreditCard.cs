using Test_Factory.Interfaces;

namespace Test_Factory.Implementations
{
	public class TitaniumCreditCard : ICreditCard
	{
		public string GetCardType()
		{
			return Constants.CreditCardNames.Titanium;
		}
		public int GetCreditLimit()
		{
			return 25000;
		}
		public int GetAnnualCharge()
		{
			return 1500;
		}
	}
}
