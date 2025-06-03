using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TestClassA2
{
    [TestFixture]

    public class Class2
    {
        [TestFixture]
        public class TriangleTestSuite
        {
            [Test]
            public void EquiCase()
            {
                var r = Triangle.AnalyzeTriangle(7, 7, 7);
                Assert.AreEqual("Equilateral triangle", r);
            }

            [Test]
            public void IsoCase1()
            {
                var r = Triangle.AnalyzeTriangle(8, 8, 5);
                Assert.AreEqual("Isosceles triangle", r);
            }

            [Test]
            public void IsoCase2()
            {
                var r = Triangle.AnalyzeTriangle(9, 4, 9);
                Assert.AreEqual("Isosceles triangle", r);
            }

            [Test]
            public void IsoCase3()
            {
                var r = Triangle.AnalyzeTriangle(12, 6, 12);
                Assert.AreEqual("Isosceles triangle", r);
            }

            [Test]
            public void ScalCase1()
            {
                var r = Triangle.AnalyzeTriangle(7, 10, 12);
                Assert.AreEqual("Scalene triangle", r);
            }

            [Test]
            public void ScalCase2()
            {
                var r = Triangle.AnalyzeTriangle(11, 13, 15);
                Assert.AreEqual("Scalene triangle", r);
            }

            [Test]
            public void ScalCase3()
            {
                var r = Triangle.AnalyzeTriangle(14, 9, 10);
                Assert.AreEqual("Scalene triangle", r);
            }

            [Test]
            public void ScalCase4()
            {
                var r = Triangle.AnalyzeTriangle(12, 7, 6);
                Assert.AreEqual("Scalene triangle", r);
            }

            [Test]
            public void ScalCase5()
            {
                var r = Triangle.AnalyzeTriangle(16, 9, 14);
                Assert.AreEqual("Scalene triangle", r);
            }

            [Test]
            public void ZeroCase1()
            {
                var r = Triangle.AnalyzeTriangle(0, 5, 7);
                Assert.AreEqual("Invalid Triangle - a zero has been detected", r);
            }

            [Test]
            public void ZeroCase2()
            {
                var r = Triangle.AnalyzeTriangle(6, 0, 8);
                Assert.AreEqual("Invalid Triangle - a zero has been detected", r);
            }

            [Test]
            public void ZeroCase3()
            {
                var r = Triangle.AnalyzeTriangle(9, 4, 0);
                Assert.AreEqual("Invalid Triangle - a zero has been detected", r);
            }

            [Test]
            public void InvalidCase1()
            {
                var r = Triangle.AnalyzeTriangle(1, 2, 4);
                Assert.AreEqual("INVALID!!", r);
            }

            [Test]
            public void InvalidCase2()
            {
                var r = Triangle.AnalyzeTriangle(2, 5, 10);
                Assert.AreEqual("INVALID!!", r);
            }

            [Test]
            public void InvalidCase3()
            {
                var r = Triangle.AnalyzeTriangle(5, 1, 2);
                Assert.AreEqual("INVALID!!", r);
            }


            // adding new

        }
    }
}
