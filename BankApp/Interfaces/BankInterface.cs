

namespace BankApp.Interfaces
{
    interface BankInterface
    {
        public decimal GetBalance();
        public decimal Withdraw();
        public decimal Deposit();
    }
}
