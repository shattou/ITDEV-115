using System;

namespace BankAccounts
{
    public class SavingsAccount : Account
    {
        private int withdrawCount;

        public SavingsAccount() : this("", 0m) { }

        public SavingsAccount(string name, decimal balance) : base(name, balance, "Savings") { }

        public override bool withdraw(decimal amount)
        {
            if (withdrawCount >= 5)
            {
                logTransaction("Savings: Transaction limit exceeded.");
                return false;
            }
            if (!base.withdraw(amount)) return false;
            withdrawCount++;
            return true;
        }
    }
}
