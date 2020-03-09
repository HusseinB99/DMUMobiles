using System;
using DMUMobilesClasses1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMU_Mobile_Testing
{
    [TestClass]
    public class tstStock
    {
        public object StockID { get; private set; }


        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.DateAdded, TestData);
        }

        [TestMethod]
        public void StockIDPropertyOK()
        {
            clsStock aStock = new clsStock();
        
            Int32 TestData = 1;
            aStock.StockID = TestData;
            Assert.AreEqual(aStock.StockID, TestData);
            

            
        }

        [TestMethod]

        public void StockDescPropertyOK()
        {
            clsStock aStock = new clsStock();

            string TestData = "iPhone 7 red";
            aStock.StockDesc = TestData;
            Assert.AreEqual(aStock.StockDesc, TestData);




        }
        [TestMethod]
        public void StockNumberPropertyOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.StockNumber = TestData;
            Assert.AreEqual(aStock.StockNumber, TestData);
        }

        [TestMethod]

        public void StockTypePropertyOK()
        {
            clsStock aStock = new clsStock();
            string TestData = "Special Offer";
            aStock.StockType = TestData;
            Assert.AreEqual(aStock.StockType, TestData);
        }

        [TestMethod]

        public void StockStatusPropertyOK()
        {
            clsStock aStock = new clsStock();
            string TestData = "Arrived";
            aStock.StockStatus = TestData;
            Assert.AreEqual(aStock.StockStatus, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = aStock.Find(StockID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStockIDFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 112;
            Found = aStock.Find(StockID);
            if (aStock.StockID != 112)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

         
        }

        [TestMethod]
        public void TestDataAddedFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 112;
            Found = aStock.Find(StockID);
            if (aStock.DateAdded != Convert.ToDateTime("15/02/2020"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
            
        }

        [TestMethod]

        public void TestStockDescFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 112;
            Found = aStock.Find(StockID);
            if(aStock.StockDesc != "iPhone 7 red")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockNumberFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 112;
            Found = aStock.Find(StockID);
            if (aStock.StockNumber != 99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockStatusFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 112;
            Found = aStock.Find(StockID);
            if (aStock.StockStatus != "Arrived")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockTypeFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 112;
            Found = aStock.Find(StockID);
            if (aStock.StockType != "Special Offer")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


       


    }
}

