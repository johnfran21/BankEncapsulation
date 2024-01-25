namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("Welcome New Customer");
            Console.WriteLine("Please Enter Deposit Amount");

            account.Deposit(25.5);
            account.GetBalance();
  
            
        }
    }
}
