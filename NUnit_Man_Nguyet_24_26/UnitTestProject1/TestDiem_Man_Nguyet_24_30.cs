
/*using System;*/

/*using NUnit.Framework.Internal;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;*/
using System;
using NUnit.Framework;
using Man_Nguyet_24_26;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestDiem_Man_Nguyet_24_30
    {
        [Test]
        public void TestHamMacDinh()
        {
            Diem_Man_Nguyet_24_30 diem = new Diem_Man_Nguyet_24_30();
            Assert.AreEqual(0, diem.X, "Loi diem X");
            Assert.AreEqual(0, diem.Y, "Loi diem Y");
        }
    }

   /* public class Diem_Man_Nguyet_24_30
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Diem_Man_Nguyet_24_30()
        {
            X = 0;
            Y = 0;
        }
    }*/
}
