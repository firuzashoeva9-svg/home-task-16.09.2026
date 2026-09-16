public class BankAccount
{
    private int accountId;
    private decimal balance;
    public string OwnerName { get; set; }
    private bool isFrozen;

    public BankAccount(int accountId, decimal balance, string ownerName)
    {
        this.accountId = accountId;
        this.balance = balance;
        OwnerName = ownerName;
    }

    public void Deposit(decimal amount)
    {
        if (!isFrozen)
        {
            balance += amount;
            System.Console.WriteLine("Transation status success.");
        }
        else
        {
            System.Console.WriteLine("Account is frozen!");
        }
    }

    public void WithDraw(decimal amount)
    {
        if (!isFrozen)
        {
            if (amount <= balance)
            {
                balance -= amount;
                System.Console.WriteLine("Successful.");
            }
            else
            {
                System.Console.WriteLine("Balance is not enough.");
            }
        }
        else
        {
            System.Console.WriteLine("Account is frozen.");
        }
    }

    public void FreezeAccount()
    {
        isFrozen = true;
        System.Console.WriteLine("The account is frozen.");
    }
    public void UnfreezeAccount()
    {
        isFrozen = false;
        System.Console.WriteLine("The account unfreezed.");
    }
}
