using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class VerifyInputUtil
    {
        public static string VerifyDate()
        {
      
            Console.Write("Please enter the date (YYYYMMDD): ");
            string dateString = Console.ReadLine();
            int date;
            bool parseSuccess = int.TryParse(dateString, out date);


            if (!parseSuccess || dateString.Length != 8)
            {
                VerifyDate();
            }

            int yearInt = Int32.Parse(dateString.Substring(0, 4));
            int monthInt = Int32.Parse(dateString.Substring(4, 2));
            int dayInt = Int32.Parse(dateString.Substring(6, 2));

            if(yearInt < 0 || yearInt> 3000)
            {
            VerifyDate();
            }

            if(monthInt > 12 || monthInt < 0)
            {
            VerifyDate();
            }

            if(dayInt > 31 || dayInt < 0) 
            {
            VerifyDate();
            }

            
            return date.ToString();
        }

        public static string VerifyDescription()
        {
            string description;
            Console.WriteLine("Please enter the description: ");
            description = Console.ReadLine();
            if (string.IsNullOrEmpty(description)) VerifyDescription();

            return description;

        }

        public static string VerifyCategory()
        {
            string category;
            Console.WriteLine("Please enter the category: ");
            category = Console.ReadLine();
            if (string.IsNullOrEmpty(category)) VerifyCategory();

            return category;

        }

        public static int VerifyAmount()
        {

            Console.WriteLine("Enter the amount");
            string amountString = Console.ReadLine();

            int amount;
            bool parseSuccess = int.TryParse(amountString, out amount);

            if (!parseSuccess || amount < 0)
            {
                VerifyAmount();
            }
     
            return amount;
            

        }


    }
}
