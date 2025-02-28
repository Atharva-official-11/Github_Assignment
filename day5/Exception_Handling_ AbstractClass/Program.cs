using Exception_Handling__AbstractClass.models;
using Exception_Handling__AbstractClass.repository;

namespace Exception_Handling__AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // left define and follow the right properties
            IAccountDetailsofBank Account = new AccountDetails();

            List<Bank> allAccount = Account.GetALlAccountDetails();

            Console.WriteLine("Before trail __________________________________________________________");
            foreach (Bank banks in allAccount)
            {
                Console.WriteLine("Accounts " + banks);
            }

            Bank CustumerTrial1 = new Bank() { CustomerAccountNumber = 6893467893, CustomerName = "kasa", CustomerBalance = 1400000 };
            Bank CustumerTrial2 = new Bank() { CustomerAccountNumber = 2579467893, CustomerName = "Light", CustomerBalance = 1400000 };

            bool ResultOfAccountVerfied = Account.IsBankAccountExists(CustumerTrial1);
            bool ResultOfAccountVerfied2 = Account.IsBankAccountExists(CustumerTrial2);
            //bool ResultOfAccountVerfied3 = Account.IsBankAccountExists(userAccountNumberInput,UserAccountName,CustomerAccountBalance);

            Console.WriteLine("First result of Customer1 -----------------------------------------------------------");
            if (ResultOfAccountVerfied)
            {
                Console.WriteLine("Account Added sucessfully!!");
            }
            else
            {
                Console.WriteLine($"Check your Account Number it is already exist!{CustumerTrial1.CustomerAccountNumber}");
            }

            Console.WriteLine("First result of Customer2 -----------------------------------------------------------");

            if (ResultOfAccountVerfied2)
            {
                Console.WriteLine("Account Added sucessfully!!");
            }
            else
            {
                Console.WriteLine($"Check your Account Number it is already exist!{CustumerTrial1.CustomerAccountNumber}");
            }

            Console.WriteLine("Final every Account exist -------------------------");
            foreach (Bank banks in allAccount)
            {
                Console.WriteLine("Accounts " + banks);
            }


        }
    }
}
