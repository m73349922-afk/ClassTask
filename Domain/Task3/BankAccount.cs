namespace Domain.Task3;

public class BankAccount
{
    public int AccountNumber;
    private decimal balance;
    public string Owner = "";
    public BankAccount(int acount, decimal Balance, string owner)
    {
        AccountNumber = acount;
        balance = Balance;
        Owner = owner;
    }
    public void TopUp(decimal amount)
    {
        if(0 < amount)
        {
            balance += amount;
            return;
        }
        Console.WriteLine("Feiled");
    }
    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return;
        }
        Console.WriteLine("You not have mone");
    }
    public decimal PrintStateMent()
    {
        return balance;
    }
}
