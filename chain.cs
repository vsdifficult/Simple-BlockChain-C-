using System; 

using System;

class BankAccount
{
    private string accountNumber;
    private string owner;
    private decimal balance;

    public BankAccount(string accountNumber, string owner, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.owner = owner;
        this.balance = balance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"{amount:C} deposited. New balance is {balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. New balance is {balance:C}");
        }
    }

    public void PrintAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Owner: {owner}");
        Console.WriteLine($"Balance: {balance:C}");
    }
}

class chain
{
    static void Main()
    {
        BankAccount account = new BankAccount("123456", "John Doe", 1000.00m);
        account.PrintAccountDetails();
        
        Console.WriteLine("==========================");
        account.Deposit(500.00m);
        account.Withdraw(200.00m);

        Console.ReadKey();
    }
}
