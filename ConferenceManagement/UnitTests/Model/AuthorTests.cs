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
    public class AuthorTests
    {
        [TestMethod()]
        public void TestGetAuthor()
        {
            Author autor = new Author(1, "Nex", "Copilu'", "nex", "***");
            Assert.AreEqual(autor.ID, 1);
            Assert.AreEqual(autor.FirstName, "Nex");
            Assert.AreEqual(autor.LastName, "Copilu'");
            Assert.AreEqual(autor.Username, "nex");
            Assert.AreEqual(autor.Password, "***");
            Console.WriteLine("All tests passed from get functions of Author");
        }

        [TestMethod]
        public void TestSetAuthor()
        {
            Author autor = new Author(1, "Nex", "Copilu'", "nex", "***");
            autor.ID = 2;
            Assert.AreEqual(autor.ID, 2);
            autor.FirstName = "Lolec";
            Assert.AreEqual(autor.FirstName, "Lolec");
            autor.LastName = "123";
            Assert.AreEqual(autor.LastName, "123");
            autor.Username = "abc";
            Assert.AreEqual(autor.Username, "abc");
            autor.Password = "abcc";
            Assert.AreEqual(autor.Password, "abcc");
            Console.WriteLine("All tests passed from set functions of Author");
        }

    }
}