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

        [TestMethod]
        public void AcsStatusResponseTest()
        {
            var response = new AcsStatusResponseCommand("98YYYNYN01000319960214    1447001.00AOID_21|AMCentral Library|BXSupported Messages|ANtty30|AFScreen Message|AGPrint Message |AY1AZDA74\r");
            response.Parse();            
        }

        [TestMethod]
        public void PatronStatusResponseTest()
        {
            var response = new PatronStatusResponseCommand("24              00119960212    100239AO|AA104000000105|AEJohn Doe|AFScreen Message|AGCheck Print message|AY2AZDFC4\r");
            response.Parse();
        }

        [TestMethod]
        public void CheckoutResponseTest()
        {
            var response = new CheckoutResponseCommand("120NNY19960212    100514AO|AA104000000105|AB000000000005792|AJ|AH|AFItem cannot be charged : see help desk|AGItem can not be charged: see help desk|AY3AZD2A1");
            response.Parse();
        }

    }
}
