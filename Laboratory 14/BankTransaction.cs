using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_14
{
    internal class BankTransaction
    {
        public readonly DateTime TransactionDateTime;
        public readonly double Amount;
        public BankTransaction(double amount)
        {
            TransactionDateTime = DateTime.Now;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"Дата: {TransactionDateTime}, сумма: {Amount}";
        }
    }
}
