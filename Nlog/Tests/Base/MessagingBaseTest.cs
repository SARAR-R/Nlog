using Epiq.TestAutomation.Api.Tests;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nlog.Tests.Base
{
    public class MessagingBaseTest : BaseApiTest
    {
        [PublicAPI]
        public static MessagingService MessagingService;

        [ClassInitialize]
        public static void MessagingBaseClassInit(TestContext context)
        {
            BaseApiClassInit(context);
            MessagingService = new MessagingService();
        }

        [ClassCleanup]
        public static void MessagingBaseClassCleanup()
        {
            BaseApiClassCleanup();
        }

    }
}
