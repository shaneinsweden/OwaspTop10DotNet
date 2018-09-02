using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace WpfBrowserTest
{
    [TestClass]
    public class WebutilsTests
    {
        [TestMethod]
        public void Deserialize_NonDangerousObject_NoBadThingsHappen()
        {
            //arrange
            string jsonText = File.ReadAllText("FundsData.txt");
            WpfBrowser.WebUtils util = new WpfBrowser.WebUtils();

            //Act 
            bool isProcessed = util.StoreDataObject(jsonText);

            //Assert
            Assert.AreEqual(true, isProcessed);
        }

        [TestMethod]
        public void Deserialize_DangerousObject_BadThingsHappen()
        {
            //arrange
            string jsonText = File.ReadAllText("CalcData.txt");
            WpfBrowser.WebUtils util = new WpfBrowser.WebUtils();

            //Act 
            bool isProcessed = util.StoreDataObject(jsonText);

            //Assert
            Assert.AreEqual(false, isProcessed);
        }
    }
}
