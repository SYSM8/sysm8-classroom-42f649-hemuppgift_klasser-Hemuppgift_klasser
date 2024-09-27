﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        //Lägg till Konstruktor
        public BankAccount(string accountNumber, string accountHolder, double balance) 
        { 
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }


        //Lägg till Metoder

        public void Deposit(double amount)
        {
            // tar ett decimal belopp som parameter och lägger till det till saldot.
            Console.WriteLine("How much money would you like to deposit?");
            amount = double.Parse(Console.ReadLine());

        }

        public void Withdraw(double balance) 
        {
            // tar ett decimal belopp som parameter och drar av det från saldot om det finns tillräckligt med pengar på kontot. 
            //Annars ska metoden meddela att uttaget inte kan genomföras.

            Console.WriteLine("How much money would you like to withdraw?");
            amount = double.Parse(Console.ReadLine());

        }

        public void DisplayBalance()
        {
            // visar det aktuella saldot på kontot
            Console.WriteLine($"Current balance: {Balance}");
        }

        //Lycka till! :) 
    }
}
