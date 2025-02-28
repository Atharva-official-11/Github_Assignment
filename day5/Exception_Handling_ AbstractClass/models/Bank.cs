

namespace Exception_Handling__AbstractClass.models
{
    class Bank
    {
        public long CustomerAccountNumber { get; set; }
        public string? CustomerName { get; set; }
        public decimal CustomerBalance { get; set; }


        public override string ToString()
        {
            return $"Account Number is ::{CustomerAccountNumber}\tname::{CustomerName}\tbalance.::{CustomerBalance}";
        }
    }
}
