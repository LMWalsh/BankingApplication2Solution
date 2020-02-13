using BankingLibrary2;
using System;

namespace BankingApplication2Project {
    class Program {
        static void Main(string[] args) {

            var chk = new Account();
                chk.Deposit(100);
                chk.Withdraw(75);

        }
    }
}
