using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HiringDate
    {

        #region Fields
        
        private string day;
        private string month;
        private string year;

        #endregion

        #region Properties
        
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public string Year
        {
            get { return Year; }
            set { Year = value; }
        }

        #endregion

        #region Constructors
        
        public HiringDate(string day, string month, string year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }

        #endregion

    }
}
