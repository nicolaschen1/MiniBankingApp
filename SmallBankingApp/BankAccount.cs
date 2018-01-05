/*********************************************
SmallBankApp

VERSION: 1.0

Description: Management of bank accounts

Developer: Nicolas CHEN
*********************************************/

using System;
using System.Collections.Generic;

namespace SmallBankingApp
{
    public abstract class BankAccount
    {
        protected List<Operation> operationsHistory;
        public string Owner { get; set; }

        public virtual decimal Balance
        {
            get
            {
                decimal total = 0;
                foreach (Operation operation in operationsHistory)
                {
                    if (operation.TypeOfMovement == Movement.Credit)
                        total += operation.Amount;
                    else
                        total -= operation.Amount;
                }
                return total;
            }
        }

        public BankAccount()
        {
            operationsHistory = new List<Operation>();
        }

        public void Credit(decimal montant)
        {
            Operation operation = new Operation
            {
                Amount = montant,
                TypeOfMovement = Movement.Credit
            };
            operationsHistory.Add(operation);
        }

        public void Credit(decimal amount, BankAccount compte)
        {
            Credit(amount);
            compte.Debit(amount);
        }

        public void Debit(decimal amount)
        {
            Operation operation = new Operation
            {
                Amount = amount,
                TypeOfMovement = Movement.Debit
            };
            operationsHistory.Add(operation);
        }

        public void Debit(decimal amount, BankAccount account)
        {
            Debit(amount);
            account.Credit(amount);
        }

        public abstract void ViewSummary();

        protected void ViewOperations()
        {
            Console.WriteLine("\n Operations List:");
            foreach (Operation operation in operationsHistory)
            {
                if (operation.TypeOfMovement == Movement.Credit)
                    Console.Write("\t+");
                else
                    Console.Write("\t-");
                Console.WriteLine(operation.Amount);
            }
        }
    }
}