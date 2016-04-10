using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Moq;
using Ninject;
using ROG_6.Model;
using ROG_6.Model.Instructies;
using ROG_6.Model.Spelregels;
using Ninject.MockingKernel;
using System.Reflection;
using ROG_6;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        LogicTestClass test;
        public UnitTest1()
        {
            test = new LogicTestClass();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //1. Arrange
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            //2. Act
            Boolean result = test.doActie(tamagotchi, 0);

            //3. Assert
            //Controleer of de tovenaar de juiste bewegingen maakt
            stafMock.Verify(s => s.Links(), Times.Once);
            stafMock.Verify(s => s.Rechts(), Times.Once);
            Assert.AreEqual("Er was licht, en hij zag dat het goed was!", result);
        }
    }
}
