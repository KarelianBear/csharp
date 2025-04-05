namespace _20250402tictactoeOOP;

public class BankAccount
{
    private string AccountNumber;
    private decimal balance;

    //constructor
    public BankAccount(string accountNumber)
    {
        balance = 0;
        this.AccountNumber = accountNumber;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (balance < amount)
        {
            return false;
        }

        balance -= amount;
        return true;

    }

    public decimal GetBalance();
    {
        return balance;
    }

    public override string ToString()
    {
        return string.Format($"Konto {AccountNumber} hat {balance} Euro");
    }
}
    