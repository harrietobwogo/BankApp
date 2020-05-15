using BankApp.Interfaces;
using BankApp.Models;
using System;


namespace BankApp.BankController
{
    class Transaction : UserDetails, BankInterface

    {   //variables
        private decimal accountBalance = 500.00M;
        private decimal amount;
        private static int userChoice;

        //properties
        public decimal AccountBalance { get => accountBalance; set => accountBalance = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public static int UserChoice { get => userChoice; set => userChoice = value; }
    //Perform Transaction Operations
        public void Operate()
        {
            Console.WriteLine("Enter UserName:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Pin Number:");
            PINNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome:" + name);
            TransactionMenu();
            UserChoice = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (UserChoice)
                {
                    case 1:
                        GetBalance();
                        Console.WriteLine("Transaction Successful");
                        performAnotherTransaction();

                        break;
                    case 2:
                        Withdraw();
                        performAnotherTransaction();

                        break;
                    case 3:
                        Deposit();
                        performAnotherTransaction();

                        break;
                    case 4:
                        Console.WriteLine("Are you sure You want to Exit: Enter Y or N:");
                        string input = Console.ReadLine().ToUpperInvariant();
                        if (input == "N")
                        {
                            performAnotherTransaction();
                        }
                        else
                        {
                            Console.WriteLine("Are you sure You want to Exit: Enter Y or N:");
                            string userInput = Console.ReadLine().ToUpperInvariant();
                            if (input == "N")
                            {
                                performAnotherTransaction();
                            }
                            else
                            {
                                Console.WriteLine("Exited Application successful!");
                            }
                            break;
                        }
                        break;
                }

            } while (UserChoice != 4);

        }
        //Do account Deposits
        public decimal Deposit()
        {
            Console.WriteLine("Available balance: " + AccountBalance);
            Console.WriteLine("Enter Amount to Deposit:");
            Amount = Convert.ToDecimal(Console.ReadLine());
            if (Amount <= 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                AccountBalance += Amount;
                Console.WriteLine("Transaction Successful. Your Balance is:" + AccountBalance);
            }
            return AccountBalance;


        }
        //get Balance of your account
        public decimal GetBalance()
        {
            Console.WriteLine("Available balance: " + AccountBalance);
            return AccountBalance;
        }
        //Withdraw from account
        public decimal Withdraw()
        {
           
            Console.WriteLine("Enter Amount to Withdraw:");
            Amount = Convert.ToDecimal(Console.ReadLine());
            if (Amount <= 0 || Amount < 500||Amount>accountBalance)
            {
                Console.WriteLine("INVALID INPUT ! ");
            }
            else if (accountBalance <= 500)
            {
                Console.WriteLine("INSUFFICIENT FUNDS!!");
                Console.WriteLine("Available balance: " + AccountBalance);
            }else
            {
                AccountBalance -= Amount;
                Console.WriteLine("Transaction Successful. Your Balance is:" + AccountBalance);
            }
            return AccountBalance;
        }
        //Application menu
       public void TransactionMenu()
        {
            Console.WriteLine("BASIC BANK APPLICATION\r");
            Console.WriteLine("_________________________\n");
            Console.WriteLine("Choose from the Provided Options the Transaction to Perform");
            Console.WriteLine("1. Check account balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Logout");

        }
        //Method to allow user to perform another transaction
        public void performAnotherTransaction()
        {
            Console.WriteLine("Would you Like to perform another transaction? Enter Y/N");
            string input = Console.ReadLine().ToUpperInvariant();
            if (input == "Y")
            {
                TransactionMenu();
                UserChoice = Convert.ToInt32(Console.ReadLine());
                do
                {
                    switch (UserChoice)
                    {
                        case 1:
                            GetBalance();
                            Console.WriteLine("Transaction Successful");
                            performAnotherTransaction();

                            break;
                        case 2:
                            Withdraw();
                            performAnotherTransaction();

                            break;
                        case 3:
                            Deposit();
                            performAnotherTransaction();

                            break;
                        case 4:
                            Console.WriteLine("Are you sure You want to Exit: Enter Y or N:");
                            string userInput = Console.ReadLine().ToUpperInvariant();
                            if (input == "N")
                            {
                                performAnotherTransaction();
                            }
                            else
                            {
                                Console.WriteLine("Exited Application successful!");
                            }
                            break;
                    }

                } while (UserChoice != 4);
            }
            else if (input == "N")
            {
                logout();
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
        //Logout from application
        public void logout()
        {
            Console.WriteLine("GoodBye:" + name);
        }
        }
    }


