using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class C1 : IMyInterface
    {
        // Initialize private data members to 0.0
        private double loanAmount = 0.0;
        private double years = 0.0;
        private double interests = 0.0;
        private double interestRate = 0.0;

        // 4 public properties for the private data members
        public double LoanAmount { get; set; }
        public double Years { get; set; }
        public double Interests { get; set; }
        public double InterestRate { get; set; }

        // Constructor with 3 parameters
        public C1(double loan, double years, double interestRate)
        {
            LoanAmount = loan;
            Years = years;
            InterestRate = interestRate;

        }

        public double PayInterests()
        {
            Interests = LoanAmount * InterestRate * Years;
            return Interests;
        } // End method PayInterests

        public void IMessage()
        {
            Console.WriteLine("Be Ready!");
        }

    }
}
