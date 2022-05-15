using PipesAndFiltersPattern.ConsoleApp.Interfaces;

namespace PipesAndFiltersPattern.ConsoleApp.Concretions
{
    public class Message : IMessage
    {
        private string messageId;
        private string body;
        private string header;
        private string subject;
        public int Priority { get; set; }
        public bool IsEncrypted { get; set; }
        public string MessageId
        {
            get { return messageId; }
        }
        public string Body
        {
            get { return body; }
        }
        public string Header
        {
            get { return header; }
        }

        public string Subject
        {
            get { return subject; }
        }
        public Message(string messageId, string body, string header, string subject)
        {
            this.messageId = messageId;
            this.body = body;
            this.header = header;
            this.subject = subject;
        }
        public bool IsMessageEncrypted() => IsEncrypted;
        public bool IsMessagePrioritySet() => (Priority != 0);

    }
}
