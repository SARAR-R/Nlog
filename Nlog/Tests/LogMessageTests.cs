using System;
using System.Threading.Tasks;
using Nlog.BusinessObjects;
using Nlog.Tests.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nlog.Tests
{
    [TestClass]
    public class LogMessageTests : MessagingBaseTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            MessagingBaseClassInit(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            MessagingBaseClassCleanup();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            RequestUri = "LogMessages/";
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public async Task MessagingNewLogMessage()
        {
            Console.WriteLine("Step: Create a new Post data object");
            var newLogMessage = new LogMessage
            {
                LogMessageId = 0,
                TenantId = "Test Tenant",
                Level = 0,
                MessageType = "Test Message",
                DateLogged = $"{new DateTime(2018, 1, 1):M/d/yyyy}",
                Username = "Test UserName",
                Location = "Postman",
                Message = "This is a test message",
                KafkaTopic = "None",
                KafkaOffset = "None"
            };


            Console.WriteLine("Step: Create the JSON request body");
            var requestBody = Serialize(newLogMessage);

            Console.WriteLine("Step: Send the POST call");
            var response = await Post(RequestUri, requestBody);

            Console.WriteLine("Get response code");
            var responseCode = GetResponseCode(response);

            Console.WriteLine("ASSERT: Verify that an ID is generated");
            Assert.IsTrue(responseCode == 202);
        }

    }
}
