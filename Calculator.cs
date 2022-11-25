namespace Patterns.PartOne
{
    public static class Calculator
    {
        /// <summary>
        /// Метод для расчета процентной ставки
        /// </summary>
        /// <param name="account"></param>
        public static void CalculateInterest(IAccount account)
        {
            // смотрим, какой текущий тип у аккаунта и выполняем расчёт ставки
            account.GetTypeAccount().CalculateInterest(account);
        }
    }
}