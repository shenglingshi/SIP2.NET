using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIP2.Core;
using SIP2.Request;
using SIP2.Core.Command;

namespace SIP2.Test
{
    [TestClass]
    public class RequestUnitTest
    {
        [TestMethod]
        public void LoginRequest()
        {
            ICommand loginRequest = new LoginRequestCommand("admin", "123");

            var requestCommand = loginRequest.ToString();
        }

        [TestMethod]
        public void ScStatusRequest()
        {
            ICommand scStatusRequest = new ScStatusRequestCommand(0, 40,2.0);
            //9900401.00AY1AZFCA5
            var scStatusCommand = scStatusRequest.ToString();
        }

        [TestMethod]
        public void ResendRequestTest()
        {
            ICommand resendRequest = new ResendRequestCommand();

            var resendRequestCommand = resendRequest.ToString();
        }

        [TestMethod]
        public void PatronStatusRequestTest()
        {
            ICommand patronStatusRequest = new PatronStatusRequestCommand("0030145332");
            var patronStatusCommand = patronStatusRequest.ToString();
        }

        [TestMethod]
        public void PatronInfoRequestTest()
        {
            ICommand patronInfoRequest = new PatronInformationRequestCommand("0030145332");
            var patronInfoCommand = patronInfoRequest.ToString();
        }

        [TestMethod]
        public void ItemInfoRequestTest()
        {
            ItemInfoRequestCommand itemInfoRequest = new ItemInfoRequestCommand("123456");
            var itemInfoCommand = itemInfoRequest.ToString();
        }

        [TestMethod]
        public void CheckInRequestTest()
        {
            CheckInRequestCommand checkInRequest = new CheckInRequestCommand("004132056231563");
            var checkInCommand = checkInRequest.ToString();
        }


        [TestMethod]
        public void BlockPatronRequestTest()
        {
            BlockPatronRequestCommand blockPatronRequest = new BlockPatronRequestCommand("Blocked Card Test");
            var blockedPatronCommand = blockPatronRequest.ToString();
        }

    }
}
