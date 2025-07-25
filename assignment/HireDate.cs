using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace assignment
{
    internal class HireDate
    {

        int[] year365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int[] year366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        private int year;
        private  int month;
        private int day;

        public int Year
        {
            get { return year; }

            set
            { 
            
                if( value >= 0 && value <= 999) 
                    year = value;
                else 
                    year = 0;
            
            
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if(value >=1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    month = 0;
                }
            }
        }



        public int Day
        {
            get { return day; }
            set
            {
                int[] arrofyear = IsLeapYear ? year366 : year365;
                if (value >= 1 && value <= arrofyear[month])
                {
                    day = value;
                }
                else {
                    day = 0;
                
                }
            }
        }


       private bool IsLeapYear  => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)? true:false;


        public HireDate()
        {
            year = 01;
            month = 0; 
            day = 0;
        }

        public  HireDate(int year , int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

    }
}
