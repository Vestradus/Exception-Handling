using System;
// Programmer:    Nicolai LeBlanc
// Date Written:  11/15/2020

namespace Assignment
{
    class Program
    {
        public static double loan;
        public static double years;
        public static double interest;
        static void Main(string[] args)
        {
            bool continueLoop = true;

            Console.WriteLine("               Mortgage Loan Calculator");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();

            // Do while loop to validate value entered into loanAmount variable
            // stops when a valid value has been entered
            do
            {
                try
                {
                    // Prompt the user to enter loan amount, years, and interest rate.
                    Console.Write("Please enter the loan amount: ");
                    loan = Convert.ToDouble(Console.ReadLine());
                    CheckLoanAmount(loan);

                    continueLoop = false; // Exit loop
                }
                catch (FormatException formatException) // Handles the exception thrown when the user enters the wrong type of value, for example, A
                {
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("Please enter a double value.\n");
                }
                catch(MyRangeException myRangeException) // Handles the exception thrown when the user enters a value less than 50000
                {
                    Console.WriteLine("\n" + myRangeException.Message);
                }
                
            } while (continueLoop);

            // Do while loop to validate value entered into years variable
            // stops when a valid value has been entered
            continueLoop = true;
            do
            {
                try
                {
                    
                    Console.Write("Please enter the number of years for the loan: ");
                    years = Convert.ToDouble(Console.ReadLine());
                    CheckLoanYears(years);

                    continueLoop = false;
                } // End try
                catch (FormatException formatException)  // Handles the exception thrown when the user enters the wrong type of value, for example, A
                {
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("Please enter a double value.\n");
                }
                catch (MyRangeException myRangeException) // Handles the exception thrown when the user enters a value less than 5
                {
                    Console.WriteLine("\n" + myRangeException.Message);
                }
            } while (continueLoop);


            // Do while loop to validate value entered into interest variable
            // stops when a valid value has been entered
            continueLoop = true;
            do
            {
                try
                {
                    Console.Write("Please enter the interest rate for the loan: ");
                    interest = Convert.ToDouble(Console.ReadLine());
                    CheckLoanInterest(interest);

                    continueLoop = false;
                } // End try
                catch (FormatException formatException)  // Handles the exception thrown when the user enters the wrong type of value, for example, A
                {
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("Please enter a double value.\n"); 
                } // End catch
                catch (MyRangeException myRangeException) // Handles the exception thrown when the user enters a value less than 0.01
                {
                    Console.WriteLine("\n" + myRangeException.Message);
                } // End catch
            } while (continueLoop);


            // Invoke the C1 constructor with 3 parameters
            C1 user = new C1(loan, years, interest);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Total Interests: ${0}", user.PayInterests()); // call PayInterests to calculate and display results
            Console.WriteLine();
            user.IMessage(); // Call IMessage interface
            Console.WriteLine("---------------------------------------------------");

            
        } // End Main method

        // Method to check if loanAmount variable is less than 50000
        public static void CheckLoanAmount(double la)
        {
            if (la < 50000)
                throw new MyRangeException("Loan Amount must be $50,000 or more.\n");
        }
        
        // Method to check if interest variable is less than 0.01
        public static void CheckLoanInterest(double it)
        {
            if (it < 0.01)
                throw new MyRangeException("Interest rate must be 1% or more.\n");
        }
        
        // Method to check if years variable is less than 5
        public static void CheckLoanYears(double yr)
        {
            if (yr < 5)
                throw new MyRangeException("Years must be 5 years or more.\n");
        }
    }
}
