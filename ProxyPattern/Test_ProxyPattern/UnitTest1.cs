using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProxyPattern;

namespace Test_ProxyPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            RealSubject real = new RealSubject();
            Proxy proxy = new Proxy(real);
            Assert.AreEqual(proxy, real);
        }
    }
}
