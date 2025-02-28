
using Exception_Handling__AbstractClass.models;

namespace Exception_Handling__AbstractClass.repository
{
  interface IAccountDetailsofBank
    {
        bool IsBankAccountExists(Bank bank);
        List<Bank> GetALlAccountDetails();

        Bank GetAccountByName(long AccountNumber);


    }
}
