using System;
using System.Collections.Generic;
using System.Linq;
/*********************************************
SmallBankApp

VERSION: 1.0

Description: Management of bank accounts

Developer: Nicolas CHEN
*********************************************/

namespace SmallBankingApp
{
    public class CurrentAccount : BankAccount
    {
        private decimal overDraftCurrentAccount;
        public CurrentAccount(decimal overDraft)
        {
            overDraftCurrentAccount = overDraft;
        }

        public override void ViewSummary()
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine(Owner + "\'s current account");
            Console.WriteLine("\tBalance: " + Balance);
            Console.WriteLine("\tOvercraft: " + overDraftCurrentAccount);
            ViewOperations();
            Console.WriteLine("=========================================================");
        }
    }
}
