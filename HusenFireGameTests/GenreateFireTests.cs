using Microsoft.VisualStudio.TestTools.UnitTesting;
using HusenFireGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusenFireGame.Tests
{
    [TestClass()]
    public class GenreateFireTests
    {
        [TestMethod()]
        public void fireTest()
        {
            GenreateFire obj=new GenreateFire();
            obj.fire();
            //Assert.Fail();
        }
    }
}