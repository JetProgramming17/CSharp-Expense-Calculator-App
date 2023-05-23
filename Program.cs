using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeAndCarLoan expenses = new HomeAndCarLoan();
            //call ABSTRACT expenses method to display it first
            expenses.TheExpenses();
            //Call home and car loan expenses
            expenses.homeLoan();
        }
    }
}
