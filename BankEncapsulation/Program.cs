namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {


            var bankAccounts = new BankAccount();
            
            Console.WriteLine("Deposit amount");
            var deposit = double.Parse(Console.ReadLine());


           bankAccounts.Deposit(deposit);
        }


    }
}
