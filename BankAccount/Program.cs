namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            BankAccount account = new BankAccount("7058, 45411", "Nän Ekman", 2000);

            account.DisplayBalance();
        }
    }
}
