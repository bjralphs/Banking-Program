/*
I declare that the following source code was written solely by me. 
I understand that copying any source code, in whole or in part, constitutes cheating, 
and that I will receive a zero on this project if I am found in violation of this policy.
*/
using System;

public class Account
{
    //Declaration of variables.
    public static string name;
    public static string address;
    public static int accountNumber = 12345678;
    public static decimal balance;
    public const int minimum = 100;
    public static int state;

    //Accoutn State Enum
    public enum AccountState
    {
        New,        // 0
        Active,     // 1
        UnderAudit, // 2
        Frozen,     // 3
        Closed      // 4
    }
    //Name Method Getter & Setter
    public bool SetName(string inName)
    {
        if (inName is null or "")
        {
            return false;
        }
        else
        {
            name = inName;
            return true;
        }
    }

    public static string GetName()
    {
        if (name is null or "")
        {
            return "No name in system.";
        }
        else
        {
            return name;
        }
    }
    //Address Method Getter & Setter
    public bool SetAddress(string inAddress)
    {
        if (inAddress is null or "")
        {
            return false;
        }
        else
        {
            address = inAddress;
            return true;
        }
    }
    public static string GetAddress()
    {
        if (address is null or "")
        {
            return "No address in system.";
        }
        else
        {
            return address;
        }
    }
    //Deposit & Withdrawal methods
    public void PayInFunds(decimal amount)
    {
        balance = balance + amount;
    }
    public bool WithdrawFunds(decimal amount)
    {
        balance = balance - amount;
        if (balance < 0)
        {
            balance = balance + amount;
            return false;
        }
        else
        {
            return true;
        }
    }
    //Balance Method Getter & Setter
    public bool SetBalance(decimal inBalance)
    {
        if (inBalance < minimum)
        {
            return false;
        }
        else
        {
            balance = inBalance;
            return true;
        }
    }
    public decimal GetBalance()
    {
        return balance;
    }
    //State Method Getter & Setter
    public void SetState(int num)
    {
        state = 0;
    }

    public int GetState()
    {
        return state;
    }



}