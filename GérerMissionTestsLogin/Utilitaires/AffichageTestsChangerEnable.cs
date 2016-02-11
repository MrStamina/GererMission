using Microsoft.VisualStudio.TestTools.UnitTesting;
using GérerMission.Utilitaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GérerMission.Utilitaires.TestsChangerEnable
{
    [TestClass()]
    public class AffichageTestsChangerEnable
    {
        [TestMethod()]
        public void TestLoginVrai()
        {
            string message1 = "plop";
            string message2 = "plop";
            bool expected = true;
            bool actual = Affichage.TestLogin(message1, message2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestLoginFaux()
        {
            string message1 = "plap";
            string message2 = "plop";
            bool expected = false;
            bool actual = Affichage.TestLogin(message1, message2);
            Assert.AreEqual(expected, actual);
        }
    }
}