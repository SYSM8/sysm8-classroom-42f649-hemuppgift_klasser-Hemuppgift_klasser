namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jane", "Smith", 30000);
            
            


            Console.WriteLine($"Annual Salary: {employee.GetAnnualSalary()}");

            employee.GiveRaise(3);

            Console.WriteLine($"New Monthly Salary: {employee.Salary/12}");
            Console.WriteLine($"New Annual Salary: {employee.GetAnnualSalary()}");

            BankAccount account = new BankAccount("123456789", "John Doe", 1000);
            account.Deposit(500);
            account.Withdraw(200);
            account.DisplayBalance();






        }
    }
}
