using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary2 {
    public class InterestAccount : Account {

        public decimal InterestRate { get; private set; }

        public void CalculateInterest(int Months) {
            var interest = this.Balance * (this.InterestRate / 12) * Months;
            Deposit(interest);
            Console.WriteLine($" Calculated interest is {interest}");
        }
            
        //below is calling ToString from Account class and adding Interest Rate
        public override string ToString() {
            return   $"{base.ToString()} Interest Rate = {InterestRate}"; 
        }

        
        
        //this is calling the ctor below which calls the base ctor
        public InterestAccount(double interestRate) : this() {
            InterestRate = Convert.ToDecimal(interestRate);
        }

        //always call the base constructor
        public InterestAccount() :base() {
            this.Description = "Interest Account"; 
        }
    }
}
