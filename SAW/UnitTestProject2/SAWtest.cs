using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    [TestClass]
    public class SAWtest
    {
        [TestMethod]
        public void RankIsThereWhenNilaiSiswaISet ()
        {
            var data = Commmon.CriteriasCollection.Get();
            Assert.IsTrue(data.Count > 0);
        }
    }
}
