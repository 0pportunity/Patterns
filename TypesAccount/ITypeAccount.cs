namespace Patterns.PartOne
{
    /// <summary>
    /// Тип аккаунта
    /// </summary>
    public interface ITypeAccount
    {
        /// <summary>
        /// Наименование типа
        /// </summary>
        public string NameType { get; }

        /// <summary>
        /// Метод расчёта процентной ставки, присущий применяемому типу аккаунта
        /// </summary>
        /// <param name="account"></param>
        void CalculateInterest(IAccount account);
    }
}