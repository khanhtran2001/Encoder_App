using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class QRGeneratorTests
    {
        [TestMethod()]
        public void setRawContentShouldReturnEmptyString()
        {
            QRGenerator qrgenerator = new QRGenerator();
            Assert.AreEqual(qrgenerator.setRawContent(""), "");
        }

    }
}