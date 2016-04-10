using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ROG_6;
using ROG_6.Model;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class InteractieTests
    {
        LogicTestClass test;
        public InteractieTests()
        {
            test = new LogicTestClass();
        }

        [TestMethod]
        public void TestEetPos()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            int result = test.doActie(tamagotchi.Object, 0);

            Assert.AreEqual(0, tamagotchi.Object.hunger);
            Assert.AreEqual(30, result, "result");
        }

        [TestMethod]
        public void TestKnuffelPos_above10()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            int result = test.doActie(tamagotchi.Object, 1);

            Assert.AreEqual(10, tamagotchi.Object.health);
            Assert.AreEqual(60, result, "result");
        }

        [TestMethod]
        public void TestKnuffelPos_under10()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 9, DateTime.Now);

            int result = test.doActie(tamagotchi.Object, 1);

            Assert.AreEqual(0, tamagotchi.Object.health);
            Assert.AreEqual(60, result, "result");
        }

        [TestMethod]
        public void TestOefenPos_above5()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            int result = test.doActie(tamagotchi.Object, 2);

            Assert.AreEqual(15, tamagotchi.Object.health);
            Assert.AreEqual(60, result, "result");
        }

        [TestMethod]
        public void TestOefenPos_under5()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 4, DateTime.Now);

            int result = test.doActie(tamagotchi.Object, 2);

            Assert.AreEqual(0, tamagotchi.Object.health);
            Assert.AreEqual(60, result, "result");
        }

        [TestMethod]
        public void TestSlaapPos()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            int result = test.doActie(tamagotchi.Object, 3);

            Assert.AreEqual(0, tamagotchi.Object.sleep);
            Assert.AreEqual(7200, result, "result");
        }

        [TestMethod]
        public void TestBoredomPos_above10()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            int result = test.doActie(tamagotchi.Object, 4);

            Assert.AreEqual(10, tamagotchi.Object.boredom);
            Assert.AreEqual(30, result, "result");
        }

        //0 = hunger
        //1 = health
        //2 = health
        //3 = sleep
        //4 = boredom

        [TestMethod]
        public void TestBoredomPos_under10()
        {
            //Tamagotchi t = new Tamagotchi("Ruben", hunger, sleep, boredom, health, lastacces)
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 5, 20, DateTime.Now);

            int result = test.doActie(tamagotchi.Object, 4);

            Assert.AreEqual(0, tamagotchi.Object.boredom);
            Assert.AreEqual(30, result, "result");
        }

        [TestMethod]
        public void TestEetName()
        {
            string result = test.getName(0);

            Assert.AreEqual("Eet", result);
        }

        [TestMethod]
        public void TestKnuffelName()
        {
            string result = test.getName(1);

            Assert.AreEqual("Knuffel", result);
        }

        [TestMethod]
        public void TestOefenName()
        {
            string result = test.getName(2);

            Assert.AreEqual("Oefen", result);
        }

        [TestMethod]
        public void TestSlaapName()
        {
            string result = test.getName(3);

            Assert.AreEqual("Slaap", result);
        }

        [TestMethod]
        public void TestSpeelName()
        {
            string result = test.getName(4);

            Assert.AreEqual("Speel", result);
        }
    }

}