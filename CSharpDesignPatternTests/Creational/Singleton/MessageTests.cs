using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDesignPattern.Creational.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern.Creational.Message.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod()]
        public void GetObjectTest()
        {
            //Check singleton object
            Assert.AreSame(Message.GetObject(), Message.GetObject());
        }
    }
}