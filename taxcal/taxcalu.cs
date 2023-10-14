using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;



namespace taxcal
{
    public class taxcalu
    {
        public static async Task taxcaluation(double amount, double rate)
        {
            salary salary = new salary();
            salary.taxname = "a";
            salary.taxid = "1";
            salary.salaryrate=amount;
            salary.taxrate= salary.taxratecal(amount);
            int a= 0;
        }
    }
}