using System;
using DMUMobilesClasses1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMU_Mobile_Testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();

            Assert.IsNotNull(AnOrder);        }
    }
}
