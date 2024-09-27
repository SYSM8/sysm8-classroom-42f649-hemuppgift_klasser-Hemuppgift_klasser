using System.ComponentModel.Design;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            BankAccount account = new BankAccount("7058, 45411-8", "Nän Ekman", 2000);

            // Anropar insättningsmetoden och skickar in det i det befintliga saldot/ Balance.
            // Lite osäker om detta är bästa sättet att anropa mina variabler från BankAccount klassen,
            // eller om användarinput ska skrivas i Main istället för i metoderna
            // Man ska väl skriva så lite som möjligt i Main? 
            account.Deposit(account.Balance);
            account.Withdraw(account.Balance);   

            account.DisplayBalance();
        }
    }
}
