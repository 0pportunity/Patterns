namespace Patterns.PartOne
{
    public class Usual : ITypeAccount
    {
        public string NameType { get { return "Обычный"; }}

        public void CalculateInterest(IAccount account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}