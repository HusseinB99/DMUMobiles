using System;
using DMUMobilesClasses1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMU_Mobile_Testing
{
    [TestClass]
    public class tstCustomerService
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerService AnCustomerService = new clsCustomerService();

            Assert.IsNotNull(AnCustomerService);
        }
    }
}
