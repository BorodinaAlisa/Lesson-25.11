using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_13
{
    enum AccountType
    {
        Current,
        Savings
    }
    internal class AccountBank
    {
        public static int accountCounter = 1000;// статическая переменная для генерации уникального номера счета
        public int AccountNumber { get; private set; }
        protected double Balance;
        public double balance
        {
            get { return Balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ошибка! Значение баланса не может быть отрицательным.");
                }

                Balance = value;
                _transactions.Add(new BankTransaction(value));
            }
        }
        public AccountType AccountType { get; }
        public string Holder { get; set; }

        public List<BankTransaction> _transactions = new List<BankTransaction>();
        public AccountBank()
        {
            AccountNumber = accountCounter;
            _transactions = new List<BankTransaction>();
            accountCounter++;
        }
        public AccountBank(double balance)
        {
            AccountNumber = accountCounter;
            Balance = balance;
            _transactions = new List<BankTransaction>();
            accountCounter++;
        }
        public AccountBank(AccountType accountType)
        {
            AccountNumber = accountCounter;
            AccountType = accountType;
            _transactions = new List<BankTransaction>();
            accountCounter++;
        }
        public AccountBank(double balance, AccountType accountType, string holder)
        {
            AccountNumber = accountCounter;
            Balance = balance;
            AccountType = accountType;
            Holder = holder;
            _transactions = new List<BankTransaction>();
            accountCounter++;
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Ошибка! Сумма снятия превышает баланс.");
            }

            Balance -= amount;
            _transactions.Add(new BankTransaction(-amount));
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            _transactions.Add(new BankTransaction(amount));
        }

        public void Transfer(AccountBank otherAccount, double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Ошибка! Сумма перевода превышает баланс.");
            }

            Withdraw(amount);
            otherAccount.Deposit(amount);
        }
        public override string ToString()
        {
            return $"Номер счета: {AccountNumber}, баланс: {Balance}, тип счета: {AccountType}, держатель: {Holder}";
        }
        public void PrintAccount()
        {
            Console.WriteLine(ToString());
        }
        public List<BankTransaction> Transactions
        {
            get { return _transactions; }
        }
        public void Dispose()
        {
            // Логика сохранения данных в файл
            using (StreamWriter writer = new StreamWriter("transactions.txt"))
            {
                foreach (var transaction in _transactions)
                {
                    writer.WriteLine($"{(transaction).TransactionDateTime}: {(transaction).Amount}");
                }
            }
            GC.SuppressFinalize(this);
        }
        public BankTransaction this[int index]
        {
            get
            {
                if (index >= 0 && index < _transactions.Count)
                {
                    return _transactions[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс находится вне диапазона.");
                }
            }
        }
    }
}

