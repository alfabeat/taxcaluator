using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxcal
{
    public class tax
    {
        public string taxname { get; set; }
        public string taxid { get; set; }
        public double taxcal(double amout, double rate)
        {
            double x = (amout / 100) * rate;
            return x;
        }        
        public double taxratecal(double amount)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            switch (amount)
            {
                case (<=12570): { 
                        return 0; }

                case (<=50270):
                    {
                        a = (amount - 12570) * 0.32;
                        return a;
                    }
                case (<= 125139):
                    {      {
                            c = (amount - 10000)/2;
                        }
                        a = (50270 - (12570-c)) * 0.32;
                        if (amount > 10000)
                  
                        b = ((amount - 50270) * 0.42)+a;


                        return b;
                    }
                case (> 125140):
                    {
                        a = (50270-12570) * 0.12;
                        b = ((amount - 50270)*0.22)+a;
                        a = ((amount - 50270) *0.47)+b;
                        return a;
                    }

            }
            return 0;
        }
    }
    public class personaltax : tax
    {
     public double hours { get; set; }
        public double hourrate { get; set; }
        public double totalamount { get; set; }
        public double totalcal() {
            double x = hours*hourrate;
            return x;
        }

        public double taxrate { get; set; }
    }
    public class salary : tax
    {
        public double salaryrate { get; set; }
        public double taxrate { get; set; }

        public double totalamount { get; set; }
    }
    public class buissnes : tax
    {
        public double income { get; set; }
        public double overhead { get; set; }

        public double amount { get; set; }
        public double totalcal()
        {
            double x = (income - overhead);
            return x;
        }
        public int rate { get; set; }
    }



}
