using System;
using System.Diagnostics;
using System.Drawing;
using Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var potintials = new Potintials();
            var teaching = new Point[2][] ;

            teaching[0] = new Point[2];
            teaching[0][0] = new Point(-5 , -5);
            teaching[0][1] = new Point(-4, 3);

            teaching[1] = new Point[2];
            teaching[1][0] = new Point(4, 5);
            teaching[1][1] = new Point(5, 5);

            Function result = potintials.GetFunction(teaching);

            Debug.Write("x: " + result.XKoef + "\ny: " + result.YKoef + "\nxy: " + result.XyKoef +
                        "\n" + result.FreeKoef);
            Assert.AreEqual(1,result.FreeKoef);
            Assert.AreEqual(-8, result.XKoef);
            Assert.AreEqual(4, result.YKoef);
            Assert.AreEqual(16, result.XyKoef);
        }
    }
}
