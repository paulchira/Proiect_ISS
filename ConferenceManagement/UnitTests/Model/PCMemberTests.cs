using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model.Tests
{
    [TestClass()]
    public class PCMemberTests
    {
        [TestMethod()]
        public void TestGetPCMember()
        {
            PCMember pcMember = new PCMember(1, "Chiorean", "Adrian", "achiorean", "abc");
            Assert.AreEqual(pcMember.ID, 1);
            Assert.AreEqual(pcMember.FirstName, "Chiorean");
            Assert.AreEqual(pcMember.LastName, "Adrian");
            Assert.AreEqual(pcMember.Username, "achiorean");
            Assert.AreEqual(pcMember.Password, "abc");
            Console.WriteLine("All tests passed from get functions of PCMember");
        }

        [TestMethod]
        public void TestSetPCMember()
        {
            PCMember pcMember = new PCMember(1, "Chiorean", "Adrian", "achiorean", "abc");
            pcMember.ID = 2;
            Assert.AreEqual(pcMember.ID, 2);
            pcMember.FirstName = "Chira";
            Assert.AreEqual(pcMember.FirstName, "Chira");
            pcMember.LastName = "Paul";
            Assert.AreEqual(pcMember.LastName, "Paul");
            pcMember.Username = "pchira";
            Assert.AreEqual(pcMember.Username, "pchira");
            pcMember.Password = "abcc";
            Assert.AreEqual(pcMember.Password, "abcc");
            Console.WriteLine("All tests passed from set functions of PCMember");
        }

        public void RunAllTests()
        {
            TestGetPCMember();
            TestSetPCMember();
            Console.WriteLine("All tests passed");
        }
    }
}