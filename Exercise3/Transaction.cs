using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Transaction
    {
        private int day;
        private int month;
        private int year;
        private int amount;
        private string description;
        private string category;

        public Transaction(int day, int month, int year, int amount, string description, string category)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.amount = amount;
            this.description = description;
            this.category = category;

        }

        public override string ToString() {
            return "(" + this.amount + "$-" + this.day + "/" + this.month + "/" + this.year + "-" +  this.description + "-" + this.category + ")";
        }

        public int Getday()
        {
            return this.day;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public int GetYear()
        {
            return this.year;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public string GetCategory()
        {
            return this.category;
        }

        public string GetDate()
        {
            return this.year.ToString() +  this.month.ToString() + this.day.ToString();
        }


    }
}
