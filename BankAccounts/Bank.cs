namespace BankAccounts
{
    public class Bank
    {
        private CheckingAccount checking;
        private SavingsAccount savings;
        private Input input = new Input();

        public void BankingApp()
        {
            input.Introduction();
            SetUpBankingAccounts();
            if (checking == null || savings == null) return;
            ModifyAccounts();
        }

        public void CreateAccount(string holder, string type, decimal balance)
        {
            if (type == "checking") checking = new CheckingAccount(holder, balance);
            else if (type == "savings") savings = new SavingsAccount(holder, balance);
        }

        public void ModifyAccounts()
        {
            int choice;
            while ((choice = input.Menu()) != 3)
            {
                if (choice == 1) input.Transfers(savings, checking);
                else
                {
                    input.PrintTransactions(savings);
                    input.PrintTransactions(checking);
                }
            }
        }

        public void SetUpBankingAccounts()
        {
            string holder = input.AccountHolder();
            if (holder == null) return;
            CreateAccount(holder, "savings", input.StartingBalance("savings"));
            CreateAccount(holder, "checking", input.StartingBalance("checking"));
            input.WelcomeMember(holder);
        }
    }
}
