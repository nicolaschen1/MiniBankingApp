/*********************************************
SmallBankApp

VERSION: 1.0

Description: Management of bank accounts

Developer: Nicolas CHEN
*********************************************/

using System;

namespace SmallBankingApp
{
    public class SavingsAccount : BankAccount
    {
        private double AbundanceRate;
        public SavingsAccount(double rate)
        {
            AbundanceRate = rate;
        }

        public override decimal Balance
        {
            get
            {
                return base.Balance * (decimal)(1 + AbundanceRate);
            }
        }

        public override void ViewSummary()
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine(Owner + "\'s savings account");
            Console.WriteLine("\tBalance: " + Balance);
            Console.WriteLine("\tRate: " + AbundanceRate);
            ViewOperations();
            Console.WriteLine("=========================================================");
        }
    }
}
