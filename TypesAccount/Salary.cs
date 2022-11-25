namespace Patterns.PartOne
{
    public class Salary : ITypeAccount
    {
        public string NameType { get { return "Зарплатный"; } }

        public void CalculateInterest(IAccount account)
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}