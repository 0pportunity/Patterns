using System;

namespace Patterns.PartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Account(); // приходит клиент, ему заводится обычный аккаунт

            client.Balance += 600; // происходит пополнение
            ShowCondition(client); // вывод текущих условий

            client.Balance += 600; // происходит пополнение
            ShowCondition(client); // вывод текущих условий

            client.Balance += 60000; // происходит пополнение
            ShowCondition(client); // вывод текущих условий

            client.ChangeType(new Salary()); // клиент захотел получать зарплату в нашем чудо-банке
            ShowCondition(client); // вывод текущих условий

            Console.ReadKey();
        }

        /// <summary>
        /// Вывод актуальных данных-условий аккаунта
        /// </summary>
        /// <param name="account"></param>
        public static void ShowCondition(Account account)
        {
            Calculator.CalculateInterest(account); // выполняется расчёт процентной ставки
            Console.WriteLine($"Для учётной записи типа {account.Type} с балансом {account.Balance} процентная ставка составит {account.Interest}"); // вывод результата
        }
    }
}