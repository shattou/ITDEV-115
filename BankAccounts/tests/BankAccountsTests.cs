using System;
using System.IO;
using BankAccounts;

class BankAccountsTests
{
    static void Check(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }

    public static void Main()
    {
        Account savings = new SavingsAccount("Alex", 100m);
        Account checking = new CheckingAccount("Alex", 50m);
        Check(savings.transferTo(checking, 25m), "Valid transfer");
        Check(savings.Balance == 75m && checking.Balance == 75m, "Both balances change");
        Check(!savings.transferTo(checking, 100m), "Reject overdraft");
        Check(!savings.transferTo(checking, -10m), "Reject negative transfer");
        Check(!savings.transferTo(checking, 0m), "Reject zero transfer");
        Check(!savings.transferTo(savings, 10m), "Reject self transfer");
        Check(!savings.transferTo(null, 10m), "Reject missing destination");
        Check(savings.Balance == 75m && checking.Balance == 75m, "Rejected transfers preserve balances");
        Check(savings.TransactionList.Count >= 2 && checking.TransactionList.Count >= 2, "Record transactions");
        for (int i = 0; i < 4; i++) Check(savings.withdraw(1m), "Allow first five withdrawals including transfer");
        Check(!savings.withdraw(1m), "Stop at savings withdrawal limit");
        Check(!savings.transferTo(checking, 1m) && checking.Balance == 75m, "Failed withdrawal cannot credit destination");
        checking.deposit(5m);
        Check(checking.withdraw(80m) && checking.Balance == 0m, "Checking can withdraw full balance");
        bool rejected = false;
        try { checking.deposit(-5m); } catch (ArgumentOutOfRangeException) { rejected = true; }
        Check(rejected && checking.Balance == 0m, "Reject negative deposit");
        Account rich = new CheckingAccount("Rich", decimal.MaxValue);
        Account source = new CheckingAccount("Alex", 10m);
        Check(!source.transferTo(rich, 1m) && source.Balance == 10m, "Overflow cannot debit the source");
        var output = new StringWriter();
        Console.SetOut(output);
        Console.SetIn(new StringReader("Alex\n100\n50\n1\ns\n25\n2\n3\n"));
        new Bank().BankingApp();
        Check(output.ToString().Contains("75"), "Console workflow shows transferred balance");
        Console.SetIn(new StringReader(""));
        new Bank().BankingApp();
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        Console.WriteLine("BankAccounts tests passed.");
    }
}
