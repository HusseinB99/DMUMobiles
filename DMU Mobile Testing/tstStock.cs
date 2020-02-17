using System;
using DMUMobilesClasses1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMU_Mobile_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create am instance of the class we want to create
            clsStock aStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(aStock);
        }
    }
}
