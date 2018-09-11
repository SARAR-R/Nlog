using System;
using Epiq.TestAutomation.Api.Core.API;
using Epiq.TestAutomation.Core.Utilities;
using static System.Console;

namespace Nlog
{
    public class MessagingService : ApiBase
    {
        public MessagingService()
        {
            WriteLine("JsonPlaceholder class initializing...");
            ApiBaseUri = ConfigUtils.GetAppConfig("ApiBaseUrl");
            AuthToken = ConfigUtils.GetAppConfig("Authorization");
            Timeout = TimeSpan.FromSeconds(30);
        }
    }
}