using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS_pirmas
{
    public class Class1
    {
        [Test]
        public static void FirstTest()
        {
            int leftower = 5 % 2;
            //Assert.AreEqual(0, leftower,"5 is not even");
            Assert.IsTrue(0 == leftower, "5 is not even");
        }

        [Test]

        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(20, currentTime.Hour, "Now is not 20");
        }
        
        [Test]

        public static void ArDalinasi()
        {
            int lefttower =  995 % 3;
            Assert.AreEqual(0, lefttower, "Something wet wrong");
        }

        [Test]

        public static void Day()
        {
            DateTime currentdate = DateTime.Now;
          //  Assert.AreEqual(DayOfWeek.Wednesday, currentTime.DayOfWeek,"Something went wrong");
        }
    }
}
