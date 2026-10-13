namespace BankAccounts
{
    public class CheckingAccount : Account
    {
        public CheckingAccount() : this("", 0m) { }

        public CheckingAccount(string name, decimal balance) : base(name, balance, "Checking") { }
    }
}
