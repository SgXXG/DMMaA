using System;
using System.Diagnostics;
using Lab4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var persiptron = new Persiptron(3, 3);
            var vectors = new Vector[3][] ;

            vectors[0] = new Vector[1];
            vectors[0][0] = new Vector(3);
            vectors[0][0].Elements[0] = 0;
            vectors[0][0].Elements[1] = 0;
            vectors[0][0].Elements[2] = 1;

            vectors[1] = new Vector[1];
            vectors[1][0] = new Vector(3);
            vectors[1][0].Elements[0] = 1;
            vectors[1][0].Elements[1] = 1;
            vectors[1][0].Elements[2] = 1;

            vectors[2] = new Vector[1];
            vectors[2][0] = new Vector(3);
            vectors[2][0].Elements[0] = -1;
            vectors[2][0].Elements[1] = 1;
            vectors[2][0].Elements[2] = 1;

            Function[] res = persiptron.GetSepareteFunctions(vectors);
            if(persiptron.Warning) Debug.WriteLine("Warning");

            Assert.AreEqual(res[0].Elements[0], 0);
            Assert.AreEqual(res[0].Elements[1], -2);
            Assert.AreEqual(res[0].Elements[2], 0);

            Assert.AreEqual(res[1].Elements[0], 2);
            Assert.AreEqual(res[1].Elements[1], 0);
            Assert.AreEqual(res[1].Elements[2], -2);

            Assert.AreEqual(res[2].Elements[0], -2);
            Assert.AreEqual(res[2].Elements[1], 0);
            Assert.AreEqual(res[2].Elements[2], -2);

        }
    }
}
