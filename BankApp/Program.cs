using BankApp.BankController;
using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction userAccount = new Transaction();
           userAccount.Operate();
           
           
        }
    }
}
