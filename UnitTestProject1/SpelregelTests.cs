using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ROG_6;
using ROG_6.Model;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class SpelregelTests
    {
        LogicTestClass test;
        public SpelregelTests()
        {
            test = new LogicTestClass();
        }

        [TestMethod]
        public void TestIsolatiePos_under95()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            test.doSpelregel(tamagotchi.Object, 0);

            Assert.AreEqual(25, tamagotchi.Object.health);
        }

        [TestMethod]
        public void TestIsolatiePos_above95()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 96, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 0);

            Assert.AreEqual(100, tamagotchi.Object.health);
        }

        [TestMethod]
        public void TestVermoeidheidPos_under95()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            test.doSpelregel(tamagotchi.Object, 3);

            Assert.AreEqual(25, tamagotchi.Object.sleep);
        }

        [TestMethod]
        public void TestVermoeidheidPos_above95()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 96, 20, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 3);

            Assert.AreEqual(100, tamagotchi.Object.sleep);
        }

        [TestMethod]
        public void TestVervelingPos_under85()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            test.doSpelregel(tamagotchi.Object, 5);

            Assert.AreEqual(35, tamagotchi.Object.boredom);
        }

        [TestMethod]
        public void TestVervelingPos_above85()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 86, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 5);

            Assert.AreEqual(100, tamagotchi.Object.boredom);
        }

        [TestMethod]
        public void TestHongerPos_normal_under95()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");

            test.doSpelregel(tamagotchi.Object, 7);

            Assert.AreEqual(25, tamagotchi.Object.hunger);
        }

        [TestMethod]
        public void TestHongerPos_normal_above95()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 96, 20, 20, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 7);

            Assert.AreEqual(100, tamagotchi.Object.hunger);
        }

        [TestMethod]
        public void TestHongerPos_hungry_under90()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test");
            tamagotchi.Object.status.setHongerig(true);

            test.doSpelregel(tamagotchi.Object, 7);

            Assert.AreEqual(30, tamagotchi.Object.hunger);
        }

        [TestMethod]
        public void TestHongerPos_hungry_above90()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 91, 20, 20, 20, DateTime.Now);
            tamagotchi.Object.status.setHongerig(true);

            test.doSpelregel(tamagotchi.Object, 7);

            Assert.AreEqual(100, tamagotchi.Object.hunger);
        }

        [TestMethod]
        public void TestTopatleetPos()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 19, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 1);

            Assert.IsTrue(tamagotchi.Object.status.getTopvorm());
        }

        [TestMethod]
        public void TestCrazyPos()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 100, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 2);

            Assert.IsTrue(tamagotchi.Object.status.getKrankzinnig());
        }

        [TestMethod]
        public void TestSlaaptekortPos()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 100, 20, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 4);

            Assert.IsFalse(tamagotchi.Object.status.getTopvorm());
            Assert.IsTrue(tamagotchi.Object.status.getOverleden());
        }

        [TestMethod]
        public void TestTrekPos()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 100, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 6);

            Assert.IsTrue(tamagotchi.Object.status.getHongerig());
        }

        [TestMethod]
        public void TestVoedseltekortPos()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 100, 20, 20, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 8);

            Assert.IsFalse(tamagotchi.Object.status.getTopvorm());
            Assert.IsTrue(tamagotchi.Object.status.getOverleden());
        }

        [TestMethod]
        public void TestTopatleetNeg_set()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 1);

            Assert.IsFalse(tamagotchi.Object.status.getTopvorm());
        }

        [TestMethod]
        public void TestTopatleetNeg_reset()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 20, DateTime.Now);
            tamagotchi.Object.status.setTopvorm(true);

            test.doSpelregel(tamagotchi.Object, 1);

            Assert.IsFalse(tamagotchi.Object.status.getTopvorm());
        }

        [TestMethod]
        public void TestCrazyNeg_set()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 99, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 2);

            Assert.IsFalse(tamagotchi.Object.status.getKrankzinnig());
        }

        [TestMethod]
        public void TestCrazyNeg_reset()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 20, 99, DateTime.Now);
            tamagotchi.Object.status.setKrankzinnig(true);

            test.doSpelregel(tamagotchi.Object, 2);

            Assert.IsFalse(tamagotchi.Object.status.getKrankzinnig());
        }

        [TestMethod]
        public void TestSlaaptekortNeg_Topvorm()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 100, 20, 20, DateTime.Now);
            tamagotchi.Object.status.setTopvorm(true);

            test.doSpelregel(tamagotchi.Object, 4);

            Assert.IsFalse(tamagotchi.Object.status.getOverleden());
        }

        [TestMethod]
        public void TestSlaaptekortNeg_Insuficient()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 99, 20, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 4);

            Assert.IsFalse(tamagotchi.Object.status.getOverleden());
        }

        [TestMethod]
        public void TestTrekNeg_set()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 80, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 6);

            Assert.IsFalse(tamagotchi.Object.status.getHongerig());
        }

        [TestMethod]
        public void TestTrekNeg_reset()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 20, 20, 80, 20, DateTime.Now);
            tamagotchi.Object.status.setHongerig(true);

            test.doSpelregel(tamagotchi.Object, 6);

            Assert.IsFalse(tamagotchi.Object.status.getHongerig());
        }

        [TestMethod]
        public void TestVoedseltekortNeg_Topvorm()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 100, 20, 20, 20, DateTime.Now);
            tamagotchi.Object.status.setTopvorm(true);

            test.doSpelregel(tamagotchi.Object, 8);

            Assert.IsFalse(tamagotchi.Object.status.getOverleden());
        }

        [TestMethod]
        public void TestVoedseltekortNeg_Insufficient()
        {
            Mock<Tamagotchi> tamagotchi = new Mock<Tamagotchi>("test", 99, 20, 20, 20, DateTime.Now);

            test.doSpelregel(tamagotchi.Object, 8);

            Assert.IsFalse(tamagotchi.Object.status.getOverleden());
        }
    }
}
