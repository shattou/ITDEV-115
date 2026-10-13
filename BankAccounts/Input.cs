using System;
using static System.Console;

namespace BankAccounts
{
    public class Input
    {
        public string AccountHolder()
        {
            WriteLine("Enter account holder name:");
            return ReadLine();
        }

        public void Introduction()
        {
            WriteLine("Welcome to Aisha's Town Bank");
            WriteLine("Create checking and savings accounts, then transfer money between them.");
        }

        public int Menu()
        {
            while (true)
            {
                WriteLine("(1) Transfer funds\n(2) Print transaction history\n(3) Quit");
                string entry = ReadLine();
                if (entry == null) return 3;
                int choice;
                if (int.TryParse(entry, out choice) && choice >= 1 && choice <= 3) return choice;
                WriteLine("Enter 1, 2, or 3.");
            }
        }

        public void PrintTransactions(Account account)
        {
            WriteLine(account.AccountName + " balance: " + account.Balance);
            foreach (string transaction in account.TransactionList) WriteLine(transaction);
        }

        public decimal StartingBalance(string account)
        {
            while (true)
            {
                WriteLine("Enter starting balance for " + account + ":");
                string entry = ReadLine();
                if (entry == null) return 0m;
                decimal balance;
                if (decimal.TryParse(entry, out balance) && balance >= 0) return balance;
                WriteLine("Enter a nonnegative amount.");
            }
        }

        public void Transfers(SavingsAccount savings, CheckingAccount checking)
        {
            WriteLine("Transfer from (s)avings or (c)hecking:");
            string selection = ReadLine();
            if (selection == null) return;
            selection = selection.Trim().ToLowerInvariant();
            if (selection != "s" && selection != "c")
            {
                WriteLine("Enter s or c.");
                return;
            }
            WriteLine("Amount to transfer:");
            decimal amount;
            if (!decimal.TryParse(ReadLine(), out amount) || amount <= 0)
            {
                WriteLine("Enter an amount greater than zero.");
                return;
            }
            Account source = selection == "s" ? (Account)savings : checking;
            Account destination = selection == "s" ? (Account)checking : savings;
            WriteLine(source.transferTo(destination, amount) ? "Transfer complete." : "Transfer could not be completed.");
        }

        public void WelcomeMember(string member)
        {
            WriteLine("Welcome, " + member + ". Your accounts are ready.");
        }
    }
}
