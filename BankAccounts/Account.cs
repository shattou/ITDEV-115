using System;
using System.Collections;

namespace BankAccounts
{
    public abstract class Account
    {
        private string name;        //Account holder name
        private decimal balance;
        private string accountName; //Account type checking or savings
        private ArrayList transactionList = new ArrayList(); //documents all transactions

        public Account(string name, decimal balance, string accountName)
        {
            if (balance < 0) throw new ArgumentOutOfRangeException(nameof(balance));
            this.name = name;
            this.balance = balance;
            this.accountName = accountName;
            logTransaction("\n" + accountName + ": Account created with starting balance " + balance);
        }

        public decimal Balance { get { return balance; } }
        public String Name { get { return name; } }
        public ArrayList TransactionList { get { return transactionList; } }
        public string AccountName { get { return accountName; } }


        public void deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
            balance += amount;
            logTransaction(accountName + ": Deposit " + amount + "\tbalance " + balance);
        }

        public virtual bool withdraw(decimal amount)
        {
            bool complete = false;
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                logTransaction(accountName + ": Withdraw " + amount + "\tbalance " + balance);
                complete = true;
            }
            else
            {
                logTransaction(accountName + ": INSUFFICENT FUNDS for the transaction");
            }
            return complete;
        }

        public void logTransaction(string transaction)
        {
            transactionList.Add(transaction);
        }

        public bool transferTo(Account account, decimal amount)
        {
            if (account == null || account == this || amount <= 0) return false;
            if (account.Balance > decimal.MaxValue - amount) return false;
            if (!withdraw(amount)) return false;
            account.deposit(amount);
            logTransaction(accountName + ": Transferred " + amount + " to " + account.AccountName);
            return true;
        }

    }
}
