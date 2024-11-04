using System;
using System.Collections.Generic;

namespace PracticeA
{
    public class Transaction
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public double Amount { get; set; }
    }

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }
        public string AccountHolder { get; set; }

        public BankAccount(int accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0;
        }

        public List<Transaction> TransactionHistory { get; private set; } = new List<Transaction>();

        public void RecordTransaction(int fromAccount, int toAccount, double amount)
        {
            TransactionHistory.Add(new Transaction { FromAccount = fromAccount, ToAccount = toAccount, Amount = amount });
        }

        public Transaction GetLastTransaction()
        {
            if (TransactionHistory.Count > 0)
            {
                return TransactionHistory[TransactionHistory.Count - 1];
            }
            return null;
        }

        public void RemoveLastTransaction()
        {
            if (TransactionHistory.Count > 0)
            {
                TransactionHistory.RemoveAt(TransactionHistory.Count - 1);
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }

    public class Bank
    {
        private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
        private int nextAccountNumber = 1000;

        // 1. Получение счета
        public BankAccount GetAccount(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                return accounts[accountNumber];
            }
            return null; // Вернуть null, если счет не найден
        }

        // 2. Отправка денег
        public bool Transfer(int fromAccountNumber, int toAccountNumber, double amount)
        {
            var fromAccount = GetAccount(fromAccountNumber);
            var toAccount = GetAccount(toAccountNumber);

            if (fromAccount != null && toAccount != null && fromAccount.Withdraw(amount))
            {
                toAccount.Deposit(amount);
                fromAccount.RecordTransaction(fromAccountNumber, toAccountNumber, amount);
                toAccount.RecordTransaction(fromAccountNumber, toAccountNumber, amount);
                return true;
            }
            return false;
        }

        // 3. Отмена операции
        public bool CancelLastTransaction(int accountNumber)
        {
            var account = GetAccount(accountNumber);
            var lastTransaction = account?.GetLastTransaction();

            if (lastTransaction != null && lastTransaction.FromAccount == accountNumber)
            {
                var toAccount = GetAccount(lastTransaction.ToAccount);
                if (toAccount != null && toAccount.Withdraw(lastTransaction.Amount))
                {
                    account.Deposit(lastTransaction.Amount);
                    account.RemoveLastTransaction();
                    toAccount.RemoveLastTransaction();
                    return true; // Возврат true, если операция отмены successful
                }
            }
            return false; // Возврат false, если отмена не удалась
        }

        // 4. Показать остаток
        public double CheckBalance(int accountNumber)
        {
            var account = GetAccount(accountNumber);
            if (account != null) // Проверка на наличие счета
            {

                return account.Balance; // Вернуть баланс, если счет найден
            }
            throw new Exception("Счет не найден."); // Исключение, если счет не найден
        }

        // Метод для добавления нового счета (для тестирования)
        public BankAccount CreateAccount(string accountHolder)
        {
            var newAccount = new BankAccount(nextAccountNumber++, accountHolder);
            accounts[newAccount.AccountNumber] = newAccount; // Добавление нового счета в словарь
            return newAccount;
        }
    }
}
