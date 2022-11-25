namespace Patterns.PartOne
{
    public interface IAccount
    {
        /// <summary>
        /// Тип учётной записи
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Баланс учетной записи
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double Interest { get; set; }

        /// <summary>
        /// Метод для получения ссылки на конкретный тип аккаунта
        /// </summary>
        public ITypeAccount GetTypeAccount();
    }
}