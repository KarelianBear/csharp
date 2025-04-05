using _20250402tictactoeOOP;
/*
BankAccount account1 = new BankAccount("123");
BankAccount account2 = new BankAccount("456");

account1.Deposit(500);
if (!account2.Withdraw(200));
{
    Console.WriteLine("Konnte nicht abheben");

    account2.Deposit(1000);
    account2.Withdraw(200);
    Console.WriteLine(account2);
    Console.WriteLine(account1);
    Console.WriteLine(account2.GetBalance());
    Console.WriteLine(account1.GetBalance());
}*/
BankAccount[] bankAccounts = new BankAccount[500];
for (int i = 0; i < bankAccounts.Length; i++)
{
    bankAccounts[i] = new BankAccount(i.ToString());
    bankAccounts[i].Deposit(10);
}

for (int i = 0; i < bankAccounts.Length; i++)
{
    Console.WriteLine(bankAccounts[i]);
}
//gwqinnapiwl 1. pl 1000 2. 500 3. 100
Random random = new Random();
int[] winners = new int[3];
decimal[] winningAmount = 
for (int i = 0; i < winners.Length; i++)
{
    int r = random.Next(0, bankAccounts.Length);
    bool found = false;
    do
    {
        found = false;
        for (int j = 0; j < winners.Length; j++)
        {
            if (winners[j] == r)
            {
                found = true;
            }    
        } 
        while (found);
        for (int i = 0; i < winners.Length; i++)
        {
            bankAccounts[winners[i]].Deposit(winningAmount[i]);
        }
    }
}