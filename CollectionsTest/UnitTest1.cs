using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CollectionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListAdd()
        {
            //Arrange
            List<int> list = new List<int>();

            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            //Assert
            Assert.AreEqual(list.Count, 6);
        }
    }
}
