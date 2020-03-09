using System;

namespace DMUMobilesClasses1
{
    public class clsStock
    {
        //private
        private Int32 mStockID;
        private DateTime mDateAdded;
        private string mStockDesc;
        private Int32 mStockNumber;
        private string mStockStatus;
        private string mStockType;




        //public
 
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
            }
        }
        public Int32 StockID
        {
            get
            {
                return mStockID;
            }

            set
            {
                mStockID = value;
            }

        }
            
        public string StockDesc
        {
            get
            {
                return mStockDesc;
            }
            set
            {
                mStockDesc = value;
            }
        }
        public Int32 StockNumber
        {
            get
            {
                return mStockNumber;
            }
            set
            {
                mStockNumber = value;
            }
        }
        public string StockType
        {
            get
            {
                return mStockType;
            }
            set
            {
                mStockType = value;
            }
        }
        public string StockStatus
        {
            get
            {
                return mStockStatus;
            }

            set
            {
                mStockStatus = value;
            }
        }

        public bool Find(int StockID)
        {
            mStockType = "Special Offer";
            mStockStatus = "Arrived";
            mStockNumber = 99;
            mStockDesc = "iPhone 7 red";
            mDateAdded = Convert.ToDateTime("15/02/2020");
            mStockID = 112;
            return true;
        }
    }
}