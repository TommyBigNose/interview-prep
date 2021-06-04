using Test_Factory.Interfaces;

namespace Test_Factory.Implementations
{
	public class PlatinumCreditCard : ICreditCard
	{
		public string GetCardType()
		{
			return Constants.CreditCardNames.Platinum;
		}
		public int GetCreditLimit()
		{
			return 35000;
		}
		public int GetAnnualCharge()
		{
			return 2000;
		}
	}
}
