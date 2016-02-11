using Microsoft.VisualStudio.TestTools.UnitTesting;
using GérerMission.Utilitaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GérerMission.Utilitaires.TestsChangerEnable
{
    [TestClass()]
    public class AffichageTestsChangerEnable
    {
        [TestMethod()]
        public void EnableTrueOrFalseTestChangerEnable()
        {
            bool x = true;
            bool expected = true;
            bool actual = Affichage.EnableTrueOrFalse(x, )
        }
    }
}