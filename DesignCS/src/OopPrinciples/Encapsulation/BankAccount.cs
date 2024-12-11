using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignCS.src.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance){
            Deposit(balance);
        }

        public decimal GetBalance(){
            return balance;
        }

        public void Deposit(decimal amount){
            if( amount <= 0){
                throw new ArgumentException("Deposit amount must be positive");
            }
            this.balance += amount;
        }

        public void Withdraw(decimal amount){
            if(amount <= 0){
                throw new ArgumentException("Withdrawal amount must be positive");
            }

            if(amount > balance){
                throw new InvalidOperationException("Insufficient Funds");
            }

            this.balance -= amount;
        }
    }
}