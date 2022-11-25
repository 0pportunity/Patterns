namespace Patterns.PartOne
{
    /// <summary>
    /// Учетная запись, аккаунт
    /// </summary>
    public class Account : IAccount
    {
        public string Type { get => typeAccount.NameType; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        private ITypeAccount typeAccount;

        /// <summary>
        /// Конструктор, создающий обычные аккаунты
        /// </summary>
        public Account() => this.typeAccount = new Usual();
        
        /// <summary>
        /// Конструктор, принимающий тип аккаунта
        /// </summary>
        /// <param name="typeAccount"></param>
        public Account(ITypeAccount typeAccount) => this.typeAccount = typeAccount;

        /// <summary>
        /// Метод для изменения типа аккаунта. Принимает тип аккаунта.
        /// </summary>
        /// <param name="newTypeAccount"></param>
        public void ChangeType(ITypeAccount newTypeAccount) => typeAccount = newTypeAccount;

        public ITypeAccount GetTypeAccount() => typeAccount;
    }
}
