using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

interface IBankAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void CheckBalance();
}
class SavingsAccount : IBankAccount
{
    private double balance = 0;
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Savings Account deposited amount: "+amount);
    }
    public void Withdraw(double amount)
    {
        balance -= amount;
        Console.WriteLine("Savings Account withdrawn ammount: "+amount);
    }
    public void CheckBalance()
    {
        Console.WriteLine("Savings Account balance: "+balance);
    }
}
class CurrentAccount : IBankAccount
{
    private double balance = 0;
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Current Account deposited amount: " + amount);
    }
    public void Withdraw(double amount)
    {
        balance -= amount;
        Console.WriteLine("Current Account withdrawn ammount: " + amount);
    }
    public void CheckBalance()
    {
        Console.WriteLine("Current Account balance: " + balance);
    }
}
class Program
{
    static void Main()
    {
        IBankAccount savings=new SavingsAccount();
        savings.Deposit(21000);
        savings.Withdraw(11000);
        savings.CheckBalance();

        IBankAccount current=new CurrentAccount();
        current.Deposit(50000);
        current.Withdraw(20000);
        current.CheckBalance();
    }

}




