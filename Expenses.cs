using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public abstract class Expenses
    {
        //declaring variables for simphiwe
        private static int grossMonthlyIncome = 0;
        private static int estMonthlyTax = 0;
        private static double TotalExpenses = 0;


        //getter and setter methods
        public int grossIncome
        {
            get { return grossMonthlyIncome; }
            set { grossMonthlyIncome = value; }
        }
        public int EstimatedTax
        {
            get { return estMonthlyTax; }
            set { estMonthlyTax = value; }
        }
        public double TotExpenses
        {
            get { return TotalExpenses; }
            set { TotalExpenses = value; }
        }
       
        public void TheExpenses()
        {
            Console.WriteLine("Enter Your Monthly Income Before Deduction: ");
            grossIncome = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Estimated Tax Deducted: ");
            estMonthlyTax = Int32.Parse(Console.ReadLine());
            //Array List that captures expenses

            List<String> Expenses = new List<string>();
            Expenses.Add("Groceries");
            Expenses.Add("Water And Lights");
            Expenses.Add("Travel Costs(Including petrol)");
            Expenses.Add("Cellphone And Telephone");
            Expenses.Add("Other Expenses");
            //list
            List<double> Expenses2 = new List<double>(5);
            //loop to iterate throught the generic list 
            for (int i = 0; i < Expenses2.Capacity; i++)
            {
                Console.Write("The Expenditure for {0}>>", Expenses[i]);
                Expenses2.Add(Convert.ToDouble(Console.ReadLine()));


            }
            Console.WriteLine("**********************************************" +
                              "*********************************************");
            Console.WriteLine("EXPENSES\n");
            for (int i = 0; i < Expenses2.Capacity; i++)
            {
                Console.WriteLine(Expenses[i] + " R" + Expenses2[i]);

            }

            TotalExpenses = Expenses2[0] + Expenses2[1] + Expenses2[2] + Expenses2[3] + Expenses2[4];

            Console.WriteLine("\nExpenses in descending order:" );
            Expenses.Reverse();

           
        }
    }
}
