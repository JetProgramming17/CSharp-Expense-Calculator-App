using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    public class HomeAndCarLoan : Expenses
    {
        //declaring variables
        private float PurchasePrice;
        private float TotalDeposit;
        private float InterestRate;
        private float AfterDeposit;
        private float Interest;
        private float n;
        private float Jet;
        private float SimpleInterest;
        private float NumberOfMonthsToRepay;
        private float RentalAmount;
        private float MonthlyRepayment;
        private float newNumOfMonths;
        private double AvailibleMonthlyAmount;
        private double totalDeductions;
        private float FirstAvailibleAmount;
        private double AfterDeduction;

        //car loan declaraions
        private String UserChoice = "";
        private string ModelAndMake;
        private float CarPurchasePrice;
        private float CarTotalDeposit;
        private float CarInterestRate;
        private float EstimatedInsuarancePremium;
        private float choice;
        private float vehicleMonthly;
        private float CarMonthlyRepaymnet;

        //Getting and Setting
        public double AftDed
        {
            get { return AfterDeduction; }
            set { AfterDeduction = value; }
        }
        public float FirAvailAm
        {
            get { return FirstAvailibleAmount; }
            set { FirstAvailibleAmount = value; }
        }
        public double totDed
        {
            get { return totalDeductions; }
            set { totalDeductions = value; }
        }
        public double AvailMonSal
        {
            get { return AvailibleMonthlyAmount; }
            set { AvailibleMonthlyAmount = value; }
        }
        public float SimInt
        {
            get { return SimpleInterest; }
            set { SimpleInterest = value; }
        }
        public float numOf
        {
            get { return n; }
            set { n = value; }
        }
        public float NewNm
        {
            get { return newNumOfMonths; }
            set { newNumOfMonths = value; }
        }
        public float IntRate
        {
            get { return InterestRate; }
            set { InterestRate = value; }
        }
        public float intrst
        {
            get { return Interest; }
            set { Interest = value; }
        }
        public float aftDeposit
        {
            get { return AfterDeposit; }
            set { AfterDeposit = value; }
        }
        public float MonRepay
        {
            get { return MonthlyRepayment; }
            set { MonthlyRepayment = value; }
        }
        public float PurPrice
        {
            get { return PurchasePrice; }
            set { PurchasePrice = value; }
        }
        public float TotDeposit
        {
            get { return TotalDeposit; }
            set { TotalDeposit = value; }
        }
        public float UpJet
        {
            get { return Jet; }
            set { Jet = value; }
        }
        public float newChoice
        {
            get { return choice; }
            set { choice = value; }
        }
        public float MonthlyVehicle
        {
            get { return vehicleMonthly; }
            set { vehicleMonthly = value; }
        }
        delegate string user();

        static string userAlert()
        {
            return "Expenses are more than your income";
        }

        public void homeLoan()
        {
            user ALERT = new user(userAlert);
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("Select 1 if you want to rent an accomodation or Press 2 if you want to buy property");
            int SELECT = Int32.Parse(Console.ReadLine());
             
            //user then has to select
            if (SELECT == 1)
            {
                Console.WriteLine("Enter Rental Amount: ");
                RentalAmount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Thank you for using the application");
                AfterDeduction = grossIncome - EstimatedTax - RentalAmount - TotExpenses;
                Console.WriteLine("Here is your availible amount after decuctions: R {0}", AfterDeduction);

            }

            //if user selects 2 they will have to input the following
            if (SELECT == 2)
            {
                Console.WriteLine("Enter purchase price of property: ");
                PurchasePrice = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter total deposit: ");
                TotalDeposit = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter interest rate(in percentage): ");
                Interest = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of months to repay(Between 240 and 360): ");
                NumberOfMonthsToRepay = Int32.Parse(Console.ReadLine());

                //Error when handling code of number of months to repay
                if (NumberOfMonthsToRepay < 240)
                {
                    //Calculations for Buying property
                    newNumOfMonths = NumberOfMonthsToRepay;
                    AfterDeposit = PurchasePrice - TotalDeposit;
                    InterestRate = Interest / 100;
                    n = NumberOfMonthsToRepay / 12;
                    Jet = InterestRate * n;
                    SimpleInterest = AfterDeposit * Jet;
                    MonthlyRepayment = SimpleInterest / NumberOfMonthsToRepay;
                    totalDeductions = grossIncome - EstimatedTax - TotExpenses - MonthlyRepayment;
                    AvailibleMonthlyAmount = totalDeductions;
                    Console.WriteLine("Please enter a number greater than 240");
                    newNumOfMonths = Int32.Parse(Console.ReadLine());
                    MonthlyRepayment = SimpleInterest / NumberOfMonthsToRepay;
                    Console.WriteLine("Monthly Repayments: R" + MonthlyRepayment);
                    Console.WriteLine("Availible Monthly Money: {0}", totalDeductions);
                }
                else if (NumberOfMonthsToRepay > 360)
                {
                    newNumOfMonths = NumberOfMonthsToRepay;
                    AfterDeposit = PurchasePrice - TotalDeposit;
                    InterestRate = Interest / 100;
                    n = NumberOfMonthsToRepay / 12;
                    Jet = InterestRate * n;
                    SimpleInterest = AfterDeposit * Jet;
                    MonthlyRepayment = SimpleInterest / NumberOfMonthsToRepay;
                    Console.WriteLine("Please enter a number less than 360");
                    //Ask user to enter the required number of months
                    newNumOfMonths = Int32.Parse(Console.ReadLine());
                    MonthlyRepayment = SimpleInterest / NumberOfMonthsToRepay;
                    totalDeductions = grossIncome - EstimatedTax - TotExpenses - MonthlyRepayment;
                    AvailibleMonthlyAmount = totalDeductions;
                    Console.WriteLine("Monthly Repayments: R" + MonthlyRepayment);
                    Console.WriteLine("Availible Monthly Money: {0}", totalDeductions);
                }
                else
                {
                    //Calculations for Buying property
                    AfterDeposit = PurchasePrice - TotalDeposit;
                    InterestRate = Interest / 100;
                    n = NumberOfMonthsToRepay / 12;
                    Jet = InterestRate * n;
                    SimpleInterest = AfterDeposit * Jet;
                    MonthlyRepayment = SimpleInterest / NumberOfMonthsToRepay;
                    totalDeductions = grossIncome - EstimatedTax - TotExpenses - MonthlyRepayment;
                    AvailibleMonthlyAmount = totalDeductions;
                    Console.WriteLine("Monthly Repayments: R" + MonthlyRepayment);
                    Console.WriteLine("Availible Monthly Money: {0}", totalDeductions);
                }
            }
            Console.WriteLine("Do you want to buy a car YES or NO");
            UserChoice = Console.ReadLine();

            switch (UserChoice.ToUpper())
            {
                case "YES":
                    Console.WriteLine("*******************************************");
                    Console.Write("Make and Model of the vehicle>>");
                    ModelAndMake = Console.ReadLine();
                    Console.Write("Price of the Vehicle>>");
                    CarPurchasePrice = float.Parse(Console.ReadLine());
                    Console.Write("The total deposit of the vehicle>>");
                    CarTotalDeposit = float.Parse(Console.ReadLine());
                    Console.Write("The interest rate>>");
                    CarInterestRate = float.Parse(Console.ReadLine());
                    //estimated insurance premium
                    Console.Write("Estimated insurance Premium Price>>");
                    EstimatedInsuarancePremium = float.Parse(Console.ReadLine());
                    //vehicle loan 
                    vehicleMonthly = CarPurchasePrice - CarTotalDeposit - EstimatedInsuarancePremium - (1 + (CarInterestRate / 100) * (5 * 12));
                    CarMonthlyRepaymnet = vehicleMonthly / (5 * 12);
                    Console.WriteLine("Vehicle Model and Make: {0}", ModelAndMake);
                    Console.WriteLine("Total Car loan Repayments: {0}", CarMonthlyRepaymnet);
                    Console.ReadLine();
                    
                    break;

                default:
                    Console.WriteLine("Thank you for using this Application");
                    break;
            }
            if (choice == 2)
            {
                Console.WriteLine("Thank You for using this app");
            }

            //Alert if the monthly repayment is greater than the 3rd of the income
            if (MonthlyRepayment > (grossIncome / 3))
            {
                Console.WriteLine("You do not qualify to take this loan");
            }
              //75% of income
            double SeventyFive = TotExpenses + vehicleMonthly + MonthlyRepayment;

            //use delegate
            if (grossIncome > SeventyFive)
            {
                Console.WriteLine(userAlert());
            }
            else
            {
                double Total = grossIncome - TotExpenses - SeventyFive;
                Console.WriteLine("The total amount left after Expenses, home and car loan have been deducted: R" + Total);

            }

        }
    }
}