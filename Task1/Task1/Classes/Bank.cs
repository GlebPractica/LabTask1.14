using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Bank
    {
        private List<Account> accounts = new List<Account>();

        public List<Account> GetAccounts() => accounts;

        // Метод добавления счета
        public void AddAccount(Account account)
        {
            if (accounts.Contains(account))
                throw new Exception("Данный аккаунт уже есть");

            accounts.Add(account);
        }

        // Метод поиска по номеру счета
        public Account FindByNumber(int number)
        {
            return accounts.FirstOrDefault(acc => acc.Number == number);
        }

        // Метод поиска по ФИО владельца
        public List<Account> FindByOwner(string fullName)
        {
            return accounts.Where(acc => acc.Owner.FullName.Equals(fullName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Метод поиска по балансу
        public List<Account> FindByBalance(decimal balance)
        {
            return accounts.Where(acc => acc.Balance == balance).ToList();
        }

        // Метод поиска по типу вклада
        public List<Account> FindByAccountType(string accountType)
        {
            return accounts.Where(acc => acc.AccountType.Equals(accountType, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Метод сортировки счетов по типу вклада
        public List<Account> SortByAccountType()
        {
            return accounts.OrderBy(acc => acc.AccountType).ToList();
        }

        // Метод сортировки счетов по дате открытия
        public List<Account> SortByOpeningDate()
        {
            return accounts.OrderBy(acc => acc.OpeningDate).ToList();
        }
    }
}
