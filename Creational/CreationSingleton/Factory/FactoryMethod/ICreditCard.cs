using System;
namespace Creational.CreationSingleton.Factory.FactoryMethod
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

    public class TitaniumCreditCard : ICreditCard
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

    public abstract class CreditCardAbstractFactory
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }

    public class MoneyBankCreditCardFactory : CreditCardAbstractFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new MoneyBackCreditCard();
        }
    }

    public class PlatinumCreditCardFactory : CreditCardAbstractFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new PlatinumCreditCard();
        }
    }

    public class TitaniumCreditCardFactory : CreditCardAbstractFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new TitaniumCreditCard();
        }
    }

    public enum CardType
    {
        MoneyBack = 1, Titanium = 2, Platinum = 3
    }

    public class CreditCardFactory
    {
        public ICreditCard GetCreditCardInstance(CardType cardType)
        {
            ICreditCard _creditCard = null;
            if (cardType == CardType.MoneyBack)
                return new MoneyBankCreditCardFactory().CreateProduct();
            else if (cardType == CardType.Platinum)
                return new PlatinumCreditCardFactory().CreateProduct();
            else if (cardType == CardType.Titanium)
                return new TitaniumCreditCardFactory().CreateProduct();
            return _creditCard;
        }
    }

    public class FactoryMethodAccessPoint
    {
        public void Start()
        {
            ICreditCard _moneyBackCreditCardDetail = new MoneyBankCreditCardFactory().CreateProduct();
            Console.WriteLine($"CardType:{_moneyBackCreditCardDetail.GetCardType()}" +
                $"\n CreditLimit: {_moneyBackCreditCardDetail.GetCreditLimit()}" +
                $"\n AnnualAverage: {_moneyBackCreditCardDetail.GetAnnualCharge()}");

            var _creditCardDetail = new CreditCardFactory().GetCreditCardInstance(CardType.Titanium);
            Console.WriteLine($"CardType:{_creditCardDetail.GetCardType()}" +
                $"\n CreditLimit: {_creditCardDetail.GetCreditLimit()}" +
                $"\n AnnualAverage: {_creditCardDetail.GetAnnualCharge()}");
        }
    }
}
