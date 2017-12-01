using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIP2.Response;

namespace SIP2.Test
{
    [TestClass]
    public class ResponseTest
    {
        [TestMethod]
        public void LoginResponseTest()
        {
            var response = new LoginResponseCommand("941AY3AZFDFA\r");
            response.Parse();
        }
    }
}
