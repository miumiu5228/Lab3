using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class HouseholdAccounts
    {
        
        private List<Transaction> history = new List<Transaction>();
        public void AddExpense()
        {
            string dateString = VerifyInputUtil.VerifyDate();
            int amount = VerifyInputUtil.VerifyAmount();
            string description = Normalize(VerifyInputUtil.VerifyDescription());
            string category = VerifyInputUtil.VerifyCategory();

            int yearInt = Int32.Parse(dateString.Substring(0, 4));
            int monthInt = Int32.Parse(dateString.Substring(4, 2));
            int dayInt = Int32.Parse(dateString.Substring(6, 2));

            Transaction transaction = new Transaction(dayInt, monthInt, yearInt, amount, description, category);
            
            history.Add(transaction);



        }

        public void SortData(ArrayList h)
        {
          

        }
        
        public void SearchCost()
        {
            string dateString1 = VerifyInputUtil.VerifyDate();
            string dateString2 = VerifyInputUtil.VerifyDate();
            string category = VerifyInputUtil.VerifyCategory();

            
            int monthInt1 = Int32.Parse(dateString1.Substring(4, 2));
            int dayInt1 = Int32.Parse(dateString1.Substring(6, 2));

            int monthInt2 = Int32.Parse(dateString2.Substring(4, 2));
            int dayInt2 = Int32.Parse(dateString2.Substring(6, 2));


            for (int i = 0; i < history.Count; i++)
            {
                if (history[i].GetCategory().Equals(category))
                {
                    int dateInt = Int32.Parse(history[i].GetDate());
                    int yearInt1 = Int32.Parse(dateString1);
                    int yearInt2 = Int32.Parse(dateString2);
                  

                    if (yearInt1 <= dateInt || dateInt <= yearInt2)
                    {
                        Console.WriteLine(history[i].ToString());
                    }
                   
                   
                }
              
            }
        }

        public void SortData()
        {
            history.Sort((x, y) => x.Getday().CompareTo(y.Getday()));
        }

        public String Normalize(String s)
        {
            s.TrimEnd();
            string stringNormalization  = s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();

            return stringNormalization;
        }
    }
}
