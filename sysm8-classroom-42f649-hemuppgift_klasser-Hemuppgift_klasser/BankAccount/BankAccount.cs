using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Employee
    {
        //Egenskaper
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

       



        //Konstruktor
        public Employee(string firstname, string lastname, double salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            

        }


        public double GetAnnualSalary()
        {
            return Salary;

        }

        public void GiveRaise(double percentage)
        {

            double raiseAmount = Salary * (percentage / 100);
            Salary += raiseAmount;
            Console.WriteLine($"Salary after {percentage}% raise: {Salary}");



        }
    }

    public class BankAccount
    {

        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountnumber, string accountholder, decimal balance)
        {
            AccountNumber = accountnumber;

            AccountHolder = accountholder;

            Balance = balance;
        }


        public void Deposit(decimal amount)
        {
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
            }


        }


        public void DisplayBalance()
        {

            Console.WriteLine("Balance: " + Balance);



        }


        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal not possible.");
            }
        }






















    }    }



