/*********************************************
SmallBankApp

VERSION: 1.0

Description: Management of bank accounts

Developer: Nicolas CHEN
*********************************************/

using System;

namespace SmallBankingApp
{
    class Program
    {
        static void Main(string[] args)
        {           
            CurrentAccount KevinAccount = new CurrentAccount(5000) { Owner = "Kevin" };
            SavingsAccount KevinSavingsAccount = new SavingsAccount(0.03) { Owner = "Kevin" };
            CurrentAccount StephenAccount = new CurrentAccount(800) { Owner = "Stephen" };
            SavingsAccount StephenSavingsAccount = new SavingsAccount(0.03) { Owner = "Stephen" };
            KevinAccount.Credit(1000);
            KevinAccount.Debit(500);
            KevinSavingsAccount.Credit(200, KevinAccount);
            KevinSavingsAccount.Credit(300);
            KevinSavingsAccount.Debit(100, KevinAccount);
            StephenAccount.Debit(400);
            StephenAccount.Debit(300, KevinAccount);
            StephenSavingsAccount.Credit(100);
            StephenSavingsAccount.Credit(50, StephenAccount);

            Console.WriteLine("=========================================================");
            Console.WriteLine(KevinAccount.Owner + "\'s current account balance" + ": " + KevinAccount.Balance);
            Console.WriteLine(KevinSavingsAccount.Owner + "\'s savings account balance" + ": " + KevinSavingsAccount.Balance);
            Console.WriteLine(StephenAccount.Owner + "\'s current account balance" + ": " + StephenAccount.Balance);
            Console.WriteLine(StephenSavingsAccount.Owner + "\'s savings account balance" + ": " + StephenSavingsAccount.Balance);
            Console.WriteLine("\n");

            //Kevin's account
            Console.WriteLine("Kevin's account summary");
            KevinAccount.ViewSummary();
            Console.WriteLine("\n");
            Console.WriteLine("Summary of Kevin's savings account");
            KevinSavingsAccount.ViewSummary();
            Console.WriteLine("\n");
            
            //Stephen's account
            Console.WriteLine("Stephen's account summary");
            StephenAccount.ViewSummary();
            Console.WriteLine("\n");
            Console.WriteLine("Summary of Stephen's savings account");
            StephenSavingsAccount.ViewSummary();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
