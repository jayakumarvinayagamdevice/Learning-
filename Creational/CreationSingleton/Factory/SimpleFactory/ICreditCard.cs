using System;
namespace Creational.CreationSingleton.Factory.SimpleFactory
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public class MoneyBackCreditCard : ICreditCard
    {
        public int GetAnnualCharge() => 500;

        public string GetCardType() => $"MoneyBack";

        public int GetCreditLimit() => 150000;
    }

    public class TitaniumCreditCard:ICreditCard
    {
        public int GetAnnualCharge() => 1000;

        public string GetCardType() => $"Titanium";

        public int GetCreditLimit() => 250000;
    }

    public class PlatinumCreditCard : ICreditCard
    {
        public int GetAnnualCharge() => 2000;

        public string GetCardType() => $"Platinum";

        public int GetCreditLimit() => 500000;
    }

    public enum CardType
    {
        MoneyBack = 1, Titanium = 2, Platinum = 3
    }

    public class CardFactory
    {
        public static ICreditCard GetCreditCardInstance(CardType cardType)
        {
            ICreditCard _creditCard = null;
            if (cardType == CardType.MoneyBack)
                return new MoneyBackCreditCard();
            else if (cardType == CardType.Platinum)
                return new PlatinumCreditCard();
            else if (cardType == CardType.Titanium)
                return new TitaniumCreditCard();
            return _creditCard;
        }
    }
    // abstruction

    public class AccessPoint
    {
        public void Start()
        {
            ICreditCard _creditCardDetail = CardFactory.GetCreditCardInstance(CardType.Platinum);
            Console.WriteLine($"CardType:{_creditCardDetail.GetCardType()}" +
                $"\n CreditLimit: {_creditCardDetail.GetCreditLimit()}" +
                $"\n AnnualAverage: {_creditCardDetail.GetAnnualCharge()}");
        }
    }
}
