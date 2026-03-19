using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2COM25A1
{
    internal class BankAccount
    {
        public string accountHolderName;
        public double balance;

        public void Deposit(double amount) {
            balance += amount; // balance = balance + amount;
            Console.WriteLine($"Deposited {amount}. New balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if(amount > balance)
            {
                Console.WriteLine("Insufficient Funds");
            }
            else
            {
                balance -= amount; // balance = balance - amount;
                Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
            }
        }

        public void DisplayInfo() {
            Console.WriteLine($"Account Holder: {accountHolderName}, Balance: {balance}");
        }
    }
}
