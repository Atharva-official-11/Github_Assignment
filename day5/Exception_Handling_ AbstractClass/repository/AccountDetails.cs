
using Exception_Handling__AbstractClass.exception;
using Exception_Handling__AbstractClass.models;

namespace Exception_Handling__AbstractClass.repository
{
    class AccountDetails : IAccountDetailsofBank
    {
        List<Bank> banks;

        public AccountDetails()
        {
            banks = new List<Bank>
            {
                new Bank(){CustomerAccountNumber=6893467893,CustomerName="Mikasa",CustomerBalance=2400000},
                new Bank(){CustomerAccountNumber=6691427394,CustomerName="Eren",CustomerBalance=22000000},
                new Bank(){CustomerAccountNumber=6436477899,CustomerName="Erwin",CustomerBalance=92000000}
            };
        }


        public bool IsBankAccountExists(Bank bank)
        {
            Bank SearchUserAccount = GetAccountByName(bank.CustomerAccountNumber);

            try
            {

                if (!banks.Contains(SearchUserAccount))
                {
                    banks.Add(bank);
                    return true;
                }
                else
                {
                    throw new CustomerAccountALlredyExistException($"Customer Account : {bank.CustomerAccountNumber} is already exist");
                }
            }
            catch (CustomerAccountALlredyExistException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public List<Bank> GetALlAccountDetails()
        {
            //Console.WriteLine("in ALl account method ..........");
            //Console.WriteLine(banks);
            return banks;
        }

        public Bank GetAccountByName(long AccountNumber)
        {
            return banks.Find(p => p.CustomerAccountNumber == AccountNumber);
        }



    }
}
