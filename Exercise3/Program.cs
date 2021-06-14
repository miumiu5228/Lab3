using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(VerifyInputUtil.VerifyDate());

            HouseholdAccounts householdAccounts = new HouseholdAccounts();

            householdAccounts.AddExpense();
            householdAccounts.SearchCost();
          

        }
    }
}
