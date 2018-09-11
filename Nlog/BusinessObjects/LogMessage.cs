using System;

namespace Nlog.BusinessObjects
{
    public class LogMessage
    {
        public int LogMessageId { get; set; }
        public string TenantId { get; set; }
        public int Level { get; set; }
        public string MessageType { get; set; }
        public string DateLogged { get; set; }
        public string Username { get; set; }
        public string Location { get; set; }
        public string Message { get; set; }
        public string KafkaTopic { get; set; }
        public string KafkaOffset { get; set; }
    }

}
