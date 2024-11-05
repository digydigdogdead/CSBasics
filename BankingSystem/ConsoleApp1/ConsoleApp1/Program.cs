namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BankAccount testAccount = new BankAccount(20202020, 200, "Carlyle", 100);

            testAccount.Withdrawing(400);

            testAccount.Depositing(200);

            testAccount.Withdrawing(400);

            Console.WriteLine(testAccount.Balance);
        }
    }
}
