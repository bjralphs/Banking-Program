/*
I declare that the following source code was written solely by me. 
I understand that copying any source code, in whole or in part, constitutes cheating, 
and that I will receive a zero on this project if I am found in violation of this policy.
*/
using System;

public class IAccount
{
    static public void Main(String[] args)
    {
        Console.WriteLine("Welcome to the UVU Banking Program");
        Account account = new Account(); //instantiate account class

        //Name method
        account.SetName("Jimmy Johns");
        string x = Account.GetName();
        Console.WriteLine("Name: " + x);

        //Address method
        account.SetAddress("123 N Nunya St.");
        string y = Account.GetAddress();
        Console.WriteLine("Address: " + y);

        //Account Number
        Console.WriteLine("account Number: "
            + Account.accountNumber);

        //Print Begining Balance
        Console.WriteLine("Balance: " + Account.balance);

        //State method
        account.SetState(0);
        int v = account.GetState();
        Account.AccountState myVar = (Account.AccountState)(v);
        Console.WriteLine("Account State: " + myVar);

        //test Deposit
        Console.WriteLine("***Depositing 200.00***");
        account.PayInFunds((decimal)200.00);
        decimal w = account.GetBalance();
        Console.WriteLine("New Balance: " + w);

        //test withdrawal
        Console.WriteLine("***Withdrawing 50.00***");
        account.WithdrawFunds((decimal)50.00);
        decimal z = account.GetBalance();
        Console.WriteLine("New Balance: " + z);

        //test overdrawn
        Console.WriteLine("***Test withdraw of 500.00***");
        if (account.WithdrawFunds((decimal)500.00) is false)
        {
            Console.WriteLine("Not enough funds to withdraw");
        }
        else
        {
            decimal f = account.GetBalance();
            Console.WriteLine("New Balance: " + f);
        }
    }
}


