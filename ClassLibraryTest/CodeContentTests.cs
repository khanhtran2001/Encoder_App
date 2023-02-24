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
    public class CodeContentTests
    {
        [TestMethod()]
        public void CreateEmptyCodeContentObjectShouldReturnEmptyStringIfGetContent() 
        {
            CodeContent content = new CodeContent();
            Assert.AreEqual("", content.getRawContent());
        }
        [TestMethod()]
        public void ChangeTheContentWhenGetContentShouldReturnThatContent()
        {
            CodeContent content = new CodeContent();
            content.ChangeContent("Hello");
            Assert.AreEqual( "Hello", content.getRawContent());
        }
    }
}